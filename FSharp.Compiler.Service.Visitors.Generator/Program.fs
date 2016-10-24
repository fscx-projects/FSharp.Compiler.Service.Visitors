//////////////////////////////////////////////////////////////////////////////
// 
// F# Compiler service's common visitors library -
//   Part of Expandable F# compiler project.
//   Author: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift)
//   GutHub: https://github.com/fscx-projects/
//
// Creative Commons Legal Code
// 
// CC0 1.0 Universal
// 
//   CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
//   LEGAL SERVICES.DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
//   ATTORNEY-CLIENT RELATIONSHIP.CREATIVE COMMONS PROVIDES THIS
//   INFORMATION ON AN "AS-IS" BASIS.CREATIVE COMMONS MAKES NO WARRANTIES
//   REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
//   PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
//   THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
//   HEREUNDER.
//
//////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Visitors.Generator

open System
open System.Linq
open System.IO
open System.Reflection

module Program =

  [<EntryPoint>]
  let main argv = 
    let time = DateTime.UtcNow
    let basePath = Path.GetFullPath argv.[0]

    let assembly = Assembly.GetExecutingAssembly()
    let generators =
      assembly.GetTypes()
      |> Seq.filter (fun t -> t.IsSealed && typeof<GeneratorBase>.IsAssignableFrom t)
      |> Seq.map (fun t -> Activator.CreateInstance t :?> GeneratorBase)
      |> Seq.toArray

    let dm =
      generators
        .AsParallel()
        .Select(fun generator -> generator.Generate basePath time)
        .ToArray()

    0
