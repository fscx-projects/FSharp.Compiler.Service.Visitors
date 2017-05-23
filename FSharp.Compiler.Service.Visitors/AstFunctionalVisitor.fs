//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 23 May 2017 08:29:34 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitors

open Microsoft.FSharp.Compiler.Ast

#nowarn "1182"

[<AutoOpen>]
module AstFunctionalVisitor =

  let rec private visitDummy () = ()

  /// <summary>
  /// Expression visitor function: ParsedFsiInteraction
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitFsiInteraction
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
        ((visitHashDirective(dlgVisitor, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedHashDirective
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitHashDirective
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective _ -> target

  /// <summary>
  /// Expression visitor function: ParsedImplFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFile
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, context, v))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitImplFileFragment(dlgVisitor, context, v))))

  /// <summary>
  /// Expression visitor function: ParsedImplFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileFragment
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
        ((visitModuleOrNamespace(dlgVisitor, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, item4, xmlDoc, item6, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, context, v))),
         xmlDoc,
         item6 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedImplFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileInput
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(fileName, isScript, qualifiedNameOfFile, scopedPragmas, hashDirectives, modules, item7) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
        (fileName,
         isScript,
         qualifiedNameOfFile,
         scopedPragmas,
         hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, context, v))),
         modules |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespace(dlgVisitor, context, v))),
         item7)

  /// <summary>
  /// Expression visitor function: ParsedInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitInput
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile
        ((visitImplFileInput(dlgVisitor, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile
        ((visitSigFileInput(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: ParsedSigFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFile
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, context, v))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSigFileFragment(dlgVisitor, context, v))))

  /// <summary>
  /// Expression visitor function: ParsedSigFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileFragment
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
        ((visitModuleOrNamespaceSig(dlgVisitor, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, item4, xmlDoc, item6, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, context, v))),
         xmlDoc,
         item6 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedSigFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileInput
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(fileName, qualifiedNameOfFile, scopedPragmas, hashDirectives, modules) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
        (fileName,
         qualifiedNameOfFile,
         scopedPragmas,
         hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, context, v))),
         modules |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespaceSig(dlgVisitor, context, v))))

  /// <summary>
  /// Expression visitor function: SynAccess
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitAccess
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Public _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Private _ -> target

  /// <summary>
  /// Expression visitor function: SynArgInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitArgInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynArgInfo(item1, optional, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         optional,
         item3)

  /// <summary>
  /// Expression visitor function: SynBinding
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBinding
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(accessibility, kind, mustInline, isMutable, attrs, xmlDoc, valData, headPat, returnInfo, expr, range, seqPoint) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding.Binding
        (accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         (visitBindingKind(dlgVisitor, context, kind)),
         mustInline,
         isMutable,
         attrs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         xmlDoc,
         (visitValData(dlgVisitor, context, valData)),
         (visitPat(dlgVisitor, context, headPat)),
         returnInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (visitBindingReturnInfo(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, expr)),
         range,
         seqPoint)

  /// <summary>
  /// Expression visitor function: SynBindingKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBindingKind
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding _ -> target

  /// <summary>
  /// Expression visitor function: SynBindingReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBindingReturnInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
        ((visitType(dlgVisitor, context, typeName)),
         range,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)))

  /// <summary>
  /// Expression visitor function: SynComponentInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitComponentInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attribs, typeParams, constraints, longId, xmlDoc, preferPostfix, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo
        (attribs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(dlgVisitor, context, v))),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, context, v))),
         longId,
         xmlDoc,
         preferPostfix,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitConst
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConst) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConst.Unit _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bool _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.SByte _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Byte _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int16 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int32 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int64 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Single _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Double _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Char _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.String _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Measure
        ((visitConst(dlgVisitor, context, constant)),
         (visitMeasure(dlgVisitor, context, item2)))

  /// <summary>
  /// Expression visitor function: SynConstructorArgs
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitConstructorArgs
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
        (item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, context, v))))
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(dlgVisitor, context, v1)))),
         range)

  /// <summary>
  /// Expression visitor function: SynEnumCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitEnumCase
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attrs, ident, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase
        (attrs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ident,
         (visitConst(dlgVisitor, context, item3)),
         item4,
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefn
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
        ((visitExceptionDefnRepr(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefnRepr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, item2, longId, xmlDoc, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitUnionCase(dlgVisitor, context, item2)),
         longId,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionSig
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig
        ((visitExceptionDefnRepr(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and private __visitExpr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        ((visitExpr(dlgVisitor, context, expr)),
         leftParenRange,
         rightParenRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
        ((visitExpr(dlgVisitor, context, operator)),
         isRaw,
         (visitExpr(dlgVisitor, context, quotedSynExpr)),
         isFromQueryExpression,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const
        ((visitConst(dlgVisitor, context, constant)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
        ((visitExpr(dlgVisitor, context, expr)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
        (exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         commaRanges,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.StructTuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.StructTuple
        (exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         commaRanges,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
        (isList,
         exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record
        (baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitType(dlgVisitor, context, v0)), (visitExpr(dlgVisitor, context, v1)), v2, v3, v4)),
         copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(dlgVisitor, context, v0)), v1)),
         recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, context, v))), v2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New
        (isProtected,
         (visitType(dlgVisitor, context, typeName)),
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOptions, bindings, extraImpls, newExprRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
        ((visitType(dlgVisitor, context, objType)),
         argOptions |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(dlgVisitor, context, v0)), v1)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, context, v))),
         extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitInterfaceImpl(dlgVisitor, context, v))),
         newExprRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(whileSeqPoint, whileExpr, doExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While
        (whileSeqPoint,
         (visitExpr(dlgVisitor, context, whileExpr)),
         (visitExpr(dlgVisitor, context, doExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(forSeqPoint, ident, identBody, item4, toBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For
        (forSeqPoint,
         ident,
         (visitExpr(dlgVisitor, context, identBody)),
         item4,
         (visitExpr(dlgVisitor, context, toBody)),
         (visitExpr(dlgVisitor, context, doBody)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(forSeqPoint, seqExprOnly, isFromSource, pat, enumExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
        (forSeqPoint,
         seqExprOnly,
         isFromSource,
         (visitPat(dlgVisitor, context, pat)),
         (visitExpr(dlgVisitor, context, enumExpr)),
         (visitExpr(dlgVisitor, context, bodyExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
        (isList,
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
        (isArrayOrList,
         isNotNakedRefCell,
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
        (fromMethod,
         inLambdaSeq,
         (visitSimplePats(dlgVisitor, context, args)),
         (visitExpr(dlgVisitor, context, body)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(isExnMatch, item2, item3, matchSeqPoint, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
        (isExnMatch,
         item2,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, context, v))),
         matchSeqPoint,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(matchSeqPoint, expr, clauses, isExnMatch, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match
        (matchSeqPoint,
         (visitExpr(dlgVisitor, context, expr)),
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, context, v))),
         isExnMatch,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(item1, isInfix, funcExpr, argExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App
        (item1,
         isInfix,
         (visitExpr(dlgVisitor, context, funcExpr)),
         (visitExpr(dlgVisitor, context, argExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, lESSrange, typeNames, commaRanges, gREATERrange, typeArgsRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
        ((visitExpr(dlgVisitor, context, expr)),
         lESSrange,
         typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         commaRanges,
         gREATERrange,
         typeArgsRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
        (isRecursive,
         isUse,
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, body)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, tryRange, withCases, withRange, range, trySeqPoint, withSeqPoint) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
        ((visitExpr(dlgVisitor, context, tryExpr)),
         tryRange,
         withCases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, context, v))),
         withRange,
         range,
         trySeqPoint,
         withSeqPoint)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, trySeqPoint, finallySeqPoint) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
        ((visitExpr(dlgVisitor, context, tryExpr)),
         (visitExpr(dlgVisitor, context, finallyExpr)),
         range,
         trySeqPoint,
         finallySeqPoint)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
        ((visitExpr(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(seqPoint, isTrueSeq, expr1, expr2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
        (seqPoint,
         isTrueSeq,
         (visitExpr(dlgVisitor, context, expr1)),
         (visitExpr(dlgVisitor, context, expr2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(ifExpr, thenExpr, elseExpr, spIfToThen, isFromErrorRecovery, ifToThenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
        ((visitExpr(dlgVisitor, context, ifExpr)),
         (visitExpr(dlgVisitor, context, thenExpr)),
         elseExpr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         spIfToThen,
         isFromErrorRecovery,
         ifToThenRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longDotId, altNameRefCell, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent
        (isOptional,
         longDotId,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(dlgVisitor, context, v.Value))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(longDotId, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
        (longDotId,
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, longDotId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
        ((visitExpr(dlgVisitor, context, expr)),
         rangeOfDot,
         longDotId,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(item1, longDotId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
        ((visitExpr(dlgVisitor, context, item1)),
         longDotId,
         (visitExpr(dlgVisitor, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
        ((visitExpr(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(dlgVisitor, context, v))),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, leftOfSetRange, dotRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
        ((visitExpr(dlgVisitor, context, objectExpr)),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, valueExpr)),
         leftOfSetRange,
         dotRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(longDotId, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
        (longDotId,
         (visitExpr(dlgVisitor, context, item2)),
         (visitExpr(dlgVisitor, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, longDotId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
        ((visitExpr(dlgVisitor, context, item1)),
         longDotId,
         (visitExpr(dlgVisitor, context, item3)),
         (visitExpr(dlgVisitor, context, item4)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
        ((visitExpr(dlgVisitor, context, expr)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
        ((visitExpr(dlgVisitor, context, expr)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
        ((visitExpr(dlgVisitor, context, expr)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(isByref, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
        (isByref,
         (visitExpr(dlgVisitor, context, item2)),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar(dlgVisitor, context, v))),
         (visitMemberSig(dlgVisitor, context, item2)),
         (visitExpr(dlgVisitor, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
        ((visitExpr(dlgVisitor, context, item1)),
         item2,
         (visitExpr(dlgVisitor, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
        (item1,
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
        (item1,
         (visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(bindSeqPoint, isUse, isFromSource, item4, item5, item6, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
        (bindSeqPoint,
         isUse,
         isFromSource,
         (visitPat(dlgVisitor, context, item4)),
         (visitExpr(dlgVisitor, context, item5)),
         (visitExpr(dlgVisitor, context, item6)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitStaticOptimizationConstraint(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, item2)),
         (visitExpr(dlgVisitor, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(expr, longId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
        ((visitExpr(dlgVisitor, context, expr)),
         longId,
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
        ((visitExpr(dlgVisitor, context, item1)),
         longId,
         item3,
         (visitExpr(dlgVisitor, context, item4)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
        ((visitExpr(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
        ((visitExpr(dlgVisitor, context, expr)),
         range)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExpr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    match dlgVisitor((fun (c, t) -> visitExpr(dlgVisitor, c, t)), context, target) with
    | Some expr -> expr
    | None -> __visitExpr(dlgVisitor, context, target)

  /// <summary>
  /// Expression visitor function: SynField
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitField
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynField) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynField.Field(attrs, isStatic, item3, item4, item5, xmlDoc, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynField.Field
        (attrs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         item3,
         (visitType(dlgVisitor, context, item4)),
         item5,
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynIndexerArg
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitIndexerArg
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
        ((visitExpr(dlgVisitor, context, item1)),
         (visitExpr(dlgVisitor, context, item2)))
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
        ((visitExpr(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynInterfaceImpl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitInterfaceImpl
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
        ((visitType(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynMatchClause
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMatchClause
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, item5) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
        ((visitPat(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, item3)),
         range,
         item5)

  /// <summary>
  /// Expression visitor function: SynMeasure
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMeasure
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
        ((visitMeasure(dlgVisitor, context, item1)),
         (visitMeasure(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMeasure(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
        ((visitMeasure(dlgVisitor, context, item1)),
         (visitMeasure(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
        ((visitMeasure(dlgVisitor, context, item1)),
         (visitRationalConst(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.One _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
        ((visitTypar(dlgVisitor, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynMemberDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMemberDefn
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
        ((visitBinding(dlgVisitor, context, memberDefn)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, context, v))),
         selfIdentifier,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
        ((visitType(dlgVisitor, context, inheritType)),
         (visitExpr(dlgVisitor, context, inheritArgs)),
         inheritAlias,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(item1, isStatic, isRecursive, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, context, v))),
         isStatic,
         isRecursive,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
        ((visitValSig(dlgVisitor, context, item1)),
         item2,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
        ((visitType(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, context, v)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
        ((visitType(dlgVisitor, context, item1)),
         item2,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
        ((visitField(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
        ((visitTypeDefn(dlgVisitor, context, typeDefn)),
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attribs, isStatic, ident, typeOpt, propKind, memberFlags, xmlDoc, accessiblity, synExpr, getSetRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
        (attribs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         ident,
         typeOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitType(dlgVisitor, context, v))),
         propKind,
         memberFlags,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         (visitExpr(dlgVisitor, context, synExpr)),
         getSetRange,
         range)

  /// <summary>
  /// Expression visitor function: SynMemberSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMemberSig
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
        ((visitValSig(dlgVisitor, context, item1)),
         item2,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
        ((visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
        ((visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
        ((visitField(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
        ((visitTypeDefnSig(dlgVisitor, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleDecl
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRecursive, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
        ((visitComponentInfo(dlgVisitor, context, item1)),
         isRecursive,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, context, v))),
         item4,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
        (item1,
         (visitExpr(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefn(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
        ((visitExceptionDefn(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
        ((visitHashDirective(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
        ((visitModuleOrNamespace(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespace
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespace
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(longId, isRecursive, isModule, decls, xmlDoc, attribs, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
        (longId,
         isRecursive,
         isModule,
         decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, context, v))),
         xmlDoc,
         attribs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespaceSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespaceSig
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(longId, isRecursive, isModule, item4, xmlDoc, attribs, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
        (longId,
         isRecursive,
         isModule,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, context, v))),
         xmlDoc,
         attribs |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleSigDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleSigDecl
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRecursive, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
        ((visitComponentInfo(dlgVisitor, context, item1)),
         isRecursive,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
        ((visitValSig(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefnSig(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
        ((visitExceptionSig(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
        ((visitHashDirective(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
        ((visitModuleOrNamespaceSig(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynPat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitPat
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynPat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynPat.Const(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const
        ((visitConst(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Wild _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, item2, isSelfIdentifier, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        ((visitPat(dlgVisitor, context, item1)),
         item2,
         isSelfIdentifier,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed
        ((visitPat(dlgVisitor, context, item1)),
         (visitType(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
        ((visitPat(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or
        ((visitPat(dlgVisitor, context, item1)),
         (visitPat(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(longDotId, item2, item3, item4, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
        (longDotId,
         item2,
         item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitValTyparDecls(dlgVisitor, context, v))),
         (visitConstructorArgs(dlgVisitor, context, item4)),
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.StructTuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.StructTuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren
        ((visitPat(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Record(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(dlgVisitor, context, v1)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
        ((visitType(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
        ((visitExpr(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
        (item1,
         item2,
         item3,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
        ((visitPat(dlgVisitor, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynRationalConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitRationalConst
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
        ((visitRationalConst(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitReturnInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo
        ((let v0, v1 = item1 in (visitType(dlgVisitor, context, v0)), (visitArgInfo(dlgVisitor, context, v1))),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePat
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
        (ident,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(dlgVisitor, context, v.Value))),
         isCompilerGenerated,
         isThisVar,
         isOptArg,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
        ((visitSimplePat(dlgVisitor, context, item1)),
         (visitType(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
        ((visitSimplePat(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePatAlternativeIdInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePatAlternativeIdInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided _ -> target

  /// <summary>
  /// Expression visitor function: SynSimplePats
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePats
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
        ((visitSimplePats(dlgVisitor, context, item1)),
         (visitType(dlgVisitor, context, item2)),
         range)

  /// <summary>
  /// Expression visitor function: SynStaticOptimizationConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitStaticOptimizationConstraint
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
        ((visitTypar(dlgVisitor, context, item1)),
         (visitType(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
        ((visitTypar(dlgVisitor, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypar
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypar
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar _ -> target

  /// <summary>
  /// Expression visitor function: SynTyparDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTyparDecl
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitTypar(dlgVisitor, context, item2)))

  /// <summary>
  /// Expression visitor function: SynType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitType
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, lESSrange, typeArgs, commaRanges, gREATERrange, isPostfix, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App
        ((visitType(dlgVisitor, context, typeName)),
         lESSrange,
         typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         commaRanges,
         gREATERrange,
         isPostfix,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, longDotId, lESSRange, typeArgs, commaRanges, gREATERrange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
        ((visitType(dlgVisitor, context, typeName)),
         longDotId,
         lESSRange,
         typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         commaRanges,
         gREATERrange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(typeNames, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple
        (typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType(dlgVisitor, context, v1)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StructTuple(typeNames, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StructTuple
        (typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType(dlgVisitor, context, v1)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array
        (item1,
         (visitType(dlgVisitor, context, elementType)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun
        ((visitType(dlgVisitor, context, argType)),
         (visitType(dlgVisitor, context, returnType)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Var(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
        ((visitType(dlgVisitor, context, typeName)),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
        ((visitType(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(dividendType, divisorType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
        ((visitType(dlgVisitor, context, dividendType)),
         (visitType(dlgVisitor, context, divisorType)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(measureType, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
        ((visitType(dlgVisitor, context, measureType)),
         (visitRationalConst(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
        ((visitConst(dlgVisitor, context, constant)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
        ((visitExpr(dlgVisitor, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(expr, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
        ((visitType(dlgVisitor, context, expr)),
         (visitType(dlgVisitor, context, item2)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeConstraint
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
        ((visitTypar(dlgVisitor, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
        ((visitTypar(dlgVisitor, context, genericName)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
        ((visitTypar(dlgVisitor, context, genericName)),
         (visitType(dlgVisitor, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
        (genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         (visitMemberSig(dlgVisitor, context, memberSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
        ((visitTypar(dlgVisitor, context, genericName)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
        ((visitTypar(dlgVisitor, context, genericName)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefn
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
        ((visitComponentInfo(dlgVisitor, context, item1)),
         (visitTypeDefnRepr(dlgVisitor, context, item2)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnKind
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate
        ((visitType(dlgVisitor, context, item1)),
         (visitValInfo(dlgVisitor, context, item2)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnRepr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
        ((visitTypeDefnKind(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
        ((visitTypeDefnSimpleRepr(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSig
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig
        ((visitComponentInfo(dlgVisitor, context, item1)),
         (visitTypeDefnSigRepr(dlgVisitor, context, item2)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnSigRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSigRepr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
        ((visitTypeDefnKind(dlgVisitor, context, item1)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
        ((visitTypeDefnSimpleRepr(dlgVisitor, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSimpleRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSimpleRepr
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessibility, unionCases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
        (accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         unionCases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitUnionCase(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitEnumCase(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessibility, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
        (accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
        ((visitTypeDefnKind(dlgVisitor, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitType(dlgVisitor, context, v0)), v1, v2)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitValSig(dlgVisitor, context, v0)), v1)),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, context, v))),
         item5,
         item6,
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, context, v)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
        (item1,
         (visitType(dlgVisitor, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, context, item)))

  /// <summary>
  /// Expression visitor function: SynUnionCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCase
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(item1, ident, item3, item4, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ident,
         (visitUnionCaseType(dlgVisitor, context, item3)),
         item4,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynUnionCaseType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCaseType
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, context, v))))
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType
        ((let v0, v1 = item in (visitType(dlgVisitor, context, v0)), (visitValInfo(dlgVisitor, context, v1))))

  /// <summary>
  /// Expression visitor function: SynValData
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValData
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValData) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynValData
        (item1,
         (visitValInfo(dlgVisitor, context, item2)),
         item3)

  /// <summary>
  /// Expression visitor function: SynValInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValInfo
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitArgInfo(dlgVisitor, context, v)))),
         (visitArgInfo(dlgVisitor, context, item2)))

  /// <summary>
  /// Expression visitor function: SynValSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValSig
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(synAttributes, ident, explicitValDecls, synType, arity, isInline, isMutable, xmlDoc, accessibility, synExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
        (synAttributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ident,
         (visitValTyparDecls(dlgVisitor, context, explicitValDecls)),
         (visitType(dlgVisitor, context, synType)),
         (visitValInfo(dlgVisitor, context, arity)),
         isInline,
         isMutable,
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, context, v))),
         synExpr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynValTyparDecls
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function (('TContext * SynExpr -> SynExpr) * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValTyparDecls
     (dlgVisitor: ('TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(dlgVisitor, context, v))),
         item2,
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, context, v))))
