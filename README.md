# F# Compiler service's visitor pattern library

![fscx-projects](https://raw.githubusercontent.com/fscx-projects/fscx/master/docs/files/img/fscx_128.png)

* TODO: This project is still work in progress, and need more documents.

## Status

| NuGet | [![NuGet FSharp.Compiler.Service.Visitors](https://img.shields.io/nuget/v/FSharp.Compiler.Service.Visitors.svg?style=flat)](https://www.nuget.org/packages/FSharp.Compiler.Service.Visitors) |
|:----|:----:|
| CI (AppVeyor) | [![AppVeyor FSharp.Compiler.Service.Visitors](https://img.shields.io/appveyor/ci/kekyo/fsharp-compiler-service-visitors/master.svg)](https://ci.appveyor.com/project/kekyo/fsharp-compiler-service-visitors) |
| Issue status | [![Issue Stats](http://issuestats.com/github/fscx-projects/FSharp.Compiler.Service.Visitors/badge/issue)](http://issuestats.com/github/fscx-projects/FSharp.Compiler.Service.Visitors) |
| Pull req | [![PR Stats](http://issuestats.com/github/fscx-projects/FSharp.Compiler.Service.Visitors/badge/pr)](http://issuestats.com/github/fscx-projects/FSharp.Compiler.Service.Visitors) |

## What is this?

* We can apply visitor pattern with minimum coding for FSharp.Compiler.Service's untyped ASTs.
* Contains two visitors:
  * "Functional visitor types. (FP based)"
  * "Inheritable (Legacy) visitor base class. (OOP based)"
* FSharp.Compiler.Service.Visitors is part of fscx-project.

### Functional visitor implementation:

* "Functional visitor" is using for functional visitor patterns with F#'s AST ([FSharp.Compiler.Services](http://fsharp.github.io/FSharp.Compiler.Service/) untyped AST).
  
```fsharp
// Functional visitor pattern (Not use custom context):
let outerVisitor
   (defaultVisitor: (NoContext * SynExpr -> SynExpr),
    context: NoContext,  // (Non custom context type)
    expr: SynExpr) : SynExpr option =

  match expr with
  | SynExpr.Quote(operator, _, _, _, _) ->
    // DEBUG
    printfn "%A" operator
    None  // (None is default visiting)

  | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
    match funcExpr with
      // ...

  | _ ->
    None  // (None is default visiting)
 
// Declare your own functional visitor.
// Type name for free.
type InsertLoggingVisitor() =
  inherit DeclareAstFunctionalVisitor(outerVisitor)
```
  
### Inheritable visitor implementation:

* "Inheritable visitor" is using for traditional visitor patterns with F#'s AST.
  * If you are implemented visitor class inherit from "AstInheritableVisitor" class.
  * "AstInheritableVisitor" are abstract classes, generic version and non-generic version.
  * Generic argument is "Context type". Context is depending any information holds for your implementations. Implicit applied "NoContext" type for non-generic version.
  * This class likely ["System.Linq.Expressions.ExpressionVisitor" class](https://msdn.microsoft.com/en-us/library/system.linq.expressions.expressionvisitor(v=vs.110).aspx).
  
```fsharp
// Inheritable visitor pattern (Not use custom context):
// Type name for free.
type InsertLoggingVisitor() =
  inherit AstInheritableVisitor()

  override __.VisitExpr_Quote(context, operator, isRaw, quoteSynExpr, isFromQueryExpression, range) =
    // DEBUG
    printfn "%A" operator
    base.VisitExpr_Quote(context, operator, isRaw, quoteSynExpr, isFromQueryExpression, range)

  override this.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, range) =
    match funcExpr with
      // ...
```

* Default visiting is derivng from AstInheritableVisitor class.
* Hooking point are "BeforeVisit*_*" or "Visit*_*".
  * "BeforeVisit" is givening for all NON-VISITED args.
  * "Visit" is givening for all VISITED args.
  
## Library depends

* FSharp.Core >= 4.0.0.1
* FSharp.Compiler.Service >= 6.0.2

## Maintainers

- [Kouji Matsui](https://github.com/kekyo) [twitter](https://twitter.com/kekyo2)
- [bleis-tift](https://github.com/bleis-tift) [twitter](https://twitter.com/bleis)

## History
* 0.9.1:
  * FCS upgraded to 12.0.8.
* 0.7.3:
  * Fixed System.Collections.Immutable version.
* 0.7.2:
  * Pinned version 1.4.2 for System.Reflection.Metadata (non-beta)
* 0.7.1:
  * Manage parent nodes using list instead stack.
  * Remove FSharpCheckFileResults args.
  * Update readme.
* 0.6.3:
  * Reduced context type constraints.
* 0.6.2:
  * Moved non generic AstInheritableVisitor.
* 0.6.1:
  * Upgraded to FSharp.Compiler Service 6.0.2 (You must be rearrenging for NuGet package installation with -Pre option, because 6.0.2 depends for System.Reflection.Metadata.dll BETA package.)
* 0.5.1:
  * Moving implements from FSharp.Expandable.Compiler.Core.
  * Code neutralize.
