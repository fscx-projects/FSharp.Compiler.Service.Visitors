@echo off

rem F# Compiler service's common visitors library -
rem   Part of Expandable F# compiler project.
rem   Author: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift)
rem   GutHub: https://github.com/fscx-projects/
rem 
rem Creative Commons Legal Code
rem 
rem CC0 1.0 Universal
rem 
rem   CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
rem   LEGAL SERVICES.DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
rem   ATTORNEY-CLIENT RELATIONSHIP.CREATIVE COMMONS PROVIDES THIS
rem   INFORMATION ON AN "AS-IS" BASIS.CREATIVE COMMONS MAKES NO WARRANTIES
rem   REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
rem   PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
rem   THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
rem   HEREUNDER.

set nupkg_version=0.6.2

.nuget\nuget pack FSharp.Compiler.Service.Visitors.nuspec -Prop Version=%nupkg_version% -Prop Configuration=Release
