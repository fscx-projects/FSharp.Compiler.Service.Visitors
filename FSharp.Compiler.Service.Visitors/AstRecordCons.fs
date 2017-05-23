//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 23 May 2017 08:29:34 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitors

open System

/// Construct record types without conflict free.
[<AutoOpen>]
module AstRecordCons =

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AssemblySymbol".
  /// </summary>
  /// <param name="fullName">string</param>
  /// <param name="cleanedIdents">string[]</param>
  /// <param name="_namespace">string[] option</param>
  /// <param name="nearestRequireQualifiedAccessParent">string[] option</param>
  /// <param name="topRequireQualifiedAccessParent">string[] option</param>
  /// <param name="autoOpenParent">string[] option</param>
  /// <param name="symbol">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpSymbol</param>
  /// <param name="kind">(Microsoft.FSharp.Compiler.SourceCodeServices.LookupType -&gt; Microsoft.FSharp.Compiler.SourceCodeServices.EntityKind)</param>
  /// <returns>Constructed record.</returns>
  let genAssemblySymbol
     (fullName: string,
      cleanedIdents: string[],
      _namespace: string[] option,
      nearestRequireQualifiedAccessParent: string[] option,
      topRequireQualifiedAccessParent: string[] option,
      autoOpenParent: string[] option,
      symbol: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpSymbol,
      kind: (Microsoft.FSharp.Compiler.SourceCodeServices.LookupType -> Microsoft.FSharp.Compiler.SourceCodeServices.EntityKind))
     : Microsoft.FSharp.Compiler.SourceCodeServices.AssemblySymbol =
    { FullName = fullName;
      CleanedIdents = cleanedIdents;
      Namespace = _namespace;
      NearestRequireQualifiedAccessParent = nearestRequireQualifiedAccessParent;
      TopRequireQualifiedAccessParent = topRequireQualifiedAccessParent;
      AutoOpenParent = autoOpenParent;
      Symbol = symbol;
      Kind = kind }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.Container".
  /// </summary>
  /// <param name="_type">Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.ContainerType</param>
  /// <param name="name">string</param>
  /// <returns>Constructed record.</returns>
  let genContainer
     (_type: Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.ContainerType,
      name: string)
     : Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.Container =
    { Type = _type;
      Name = name }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.Entity".
  /// </summary>
  /// <param name="fullRelativeName">string</param>
  /// <param name="qualifier">string</param>
  /// <param name="_namespace">string option</param>
  /// <param name="name">string</param>
  /// <param name="lastIdent">string</param>
  /// <returns>Constructed record.</returns>
  let genEntity
     (fullRelativeName: string,
      qualifier: string,
      _namespace: string option,
      name: string,
      lastIdent: string)
     : Microsoft.FSharp.Compiler.SourceCodeServices.Entity =
    { FullRelativeName = fullRelativeName;
      Qualifier = qualifier;
      Namespace = _namespace;
      Name = name;
      LastIdent = lastIdent }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration".
  /// </summary>
  /// <param name="declaration">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem</param>
  /// <param name="nested">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem[]</param>
  /// <returns>Constructed record.</returns>
  let genFSharpNavigationTopLevelDeclaration
     (declaration: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem,
      nested: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem[])
     : Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration =
    { Declaration = declaration;
      Nested = nested }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions".
  /// </summary>
  /// <param name="projectFileName">string</param>
  /// <param name="projectFileNames">string[]</param>
  /// <param name="otherOptions">string[]</param>
  /// <param name="referencedProjects">(string * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions)[]</param>
  /// <param name="isIncompleteTypeCheckEnvironment">bool</param>
  /// <param name="useScriptResolutionRules">bool</param>
  /// <param name="loadTime">System.DateTime</param>
  /// <param name="unresolvedReferences">Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedReferencesSet option</param>
  /// <param name="originalLoadReferences">(Microsoft.FSharp.Compiler.Range.range * string) list</param>
  /// <param name="extraProjectInfo">System.Object option</param>
  /// <returns>Constructed record.</returns>
  let genFSharpProjectOptions
     (projectFileName: string,
      projectFileNames: string[],
      otherOptions: string[],
      referencedProjects: (string * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions)[],
      isIncompleteTypeCheckEnvironment: bool,
      useScriptResolutionRules: bool,
      loadTime: System.DateTime,
      unresolvedReferences: Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedReferencesSet option,
      originalLoadReferences: (Microsoft.FSharp.Compiler.Range.range * string) list,
      extraProjectInfo: System.Object option)
     : Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions =
    { ProjectFileName = projectFileName;
      ProjectFileNames = projectFileNames;
      OtherOptions = otherOptions;
      ReferencedProjects = referencedProjects;
      IsIncompleteTypeCheckEnvironment = isIncompleteTypeCheckEnvironment;
      UseScriptResolutionRules = useScriptResolutionRules;
      LoadTime = loadTime;
      UnresolvedReferences = unresolvedReferences;
      OriginalLoadReferences = originalLoadReferences;
      ExtraProjectInfo = extraProjectInfo }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo".
  /// </summary>
  /// <param name="leftColumn">int</param>
  /// <param name="rightColumn">int</param>
  /// <param name="colorClass">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenColorKind</param>
  /// <param name="charClass">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenCharKind</param>
  /// <param name="fSharpTokenTriggerClass">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenTriggerClass</param>
  /// <param name="tag">int</param>
  /// <param name="tokenName">string</param>
  /// <param name="fullMatchedLength">int</param>
  /// <returns>Constructed record.</returns>
  let genFSharpTokenInfo
     (leftColumn: int,
      rightColumn: int,
      colorClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenColorKind,
      charClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenCharKind,
      fSharpTokenTriggerClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenTriggerClass,
      tag: int,
      tokenName: string,
      fullMatchedLength: int)
     : Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo =
    { LeftColumn = leftColumn;
      RightColumn = rightColumn;
      ColorClass = colorClass;
      CharClass = charClass;
      FSharpTokenTriggerClass = fSharpTokenTriggerClass;
      Tag = tag;
      TokenName = tokenName;
      FullMatchedLength = fullMatchedLength }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="auxModuleHashAlgorithm">int</param>
  /// <param name="securityDecls">Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions</param>
  /// <param name="publicKey">byte[] option</param>
  /// <param name="version">(System.UInt16 * System.UInt16 * System.UInt16 * System.UInt16) option</param>
  /// <param name="locale">string option</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <param name="assemblyLongevity">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity</param>
  /// <param name="disableJitOptimizations">bool</param>
  /// <param name="jitTracking">bool</param>
  /// <param name="ignoreSymbolStoreSequencePoints">bool</param>
  /// <param name="retargetable">bool</param>
  /// <param name="exportedTypes">Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypesAndForwarders</param>
  /// <param name="entrypointElsewhere">Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef option</param>
  /// <returns>Constructed record.</returns>
  let genILAssemblyManifest
     (name: string,
      auxModuleHashAlgorithm: int,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      publicKey: byte[] option,
      version: (System.UInt16 * System.UInt16 * System.UInt16 * System.UInt16) option,
      locale: string option,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      assemblyLongevity: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity,
      disableJitOptimizations: bool,
      jitTracking: bool,
      ignoreSymbolStoreSequencePoints: bool,
      retargetable: bool,
      exportedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypesAndForwarders,
      entrypointElsewhere: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef option)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest =
    { Name = name;
      AuxModuleHashAlgorithm = auxModuleHashAlgorithm;
      SecurityDecls = securityDecls;
      PublicKey = publicKey;
      Version = version;
      Locale = locale;
      CustomAttrs = customAttrs;
      AssemblyLongevity = assemblyLongevity;
      DisableJitOptimizations = disableJitOptimizations;
      JitTracking = jitTracking;
      IgnoreSymbolStoreSequencePoints = ignoreSymbolStoreSequencePoints;
      Retargetable = retargetable;
      ExportedTypes = exportedTypes;
      EntrypointElsewhere = entrypointElsewhere }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute".
  /// </summary>
  /// <param name="_method">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <param name="data">byte[]</param>
  /// <returns>Constructed record.</returns>
  let genILAttribute
     (_method: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec,
      data: byte[])
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute =
    { Method = _method;
      Data = data }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature".
  /// </summary>
  /// <param name="callingConv">Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv</param>
  /// <param name="argTypes">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list</param>
  /// <param name="returnType">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed record.</returns>
  let genILCallingSignature
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv,
      argTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      returnType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature =
    { CallingConv = callingConv;
      ArgTypes = argTypes;
      ReturnType = returnType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode".
  /// </summary>
  /// <param name="labels">System.Collections.Generic.Dictionary&lt;int, int&gt;</param>
  /// <param name="instrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[]</param>
  /// <param name="exceptions">Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec list</param>
  /// <param name="locals">Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo list</param>
  /// <returns>Constructed record.</returns>
  let genILCode
     (labels: System.Collections.Generic.Dictionary<int, int>,
      instrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
      exceptions: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec list,
      locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo list)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode =
    { Labels = labels;
      Instrs = instrs;
      Exceptions = exceptions;
      Locals = locals }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo".
  /// </summary>
  /// <param name="enumValues">(string * Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit) list</param>
  /// <param name="enumType">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed record.</returns>
  let genILEnumInfo
     (enumValues: (string * Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit) list,
      enumType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo =
    { enumValues = enumValues;
      enumType = enumType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef".
  /// </summary>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option</param>
  /// <param name="name">string</param>
  /// <param name="isRTSpecialName">bool</param>
  /// <param name="isSpecialName">bool</param>
  /// <param name="addMethod">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef</param>
  /// <param name="removeMethod">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef</param>
  /// <param name="fireMethod">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option</param>
  /// <param name="otherMethods">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef list</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILEventDef
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      name: string,
      isRTSpecialName: bool,
      isSpecialName: bool,
      addMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef,
      removeMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef,
      fireMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      otherMethods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef =
    { Type = _type;
      Name = name;
      IsRTSpecialName = isRTSpecialName;
      IsSpecialName = isSpecialName;
      AddMethod = addMethod;
      RemoveMethod = removeMethod;
      FireMethod = fireMethod;
      OtherMethods = otherMethods;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec".
  /// </summary>
  /// <param name="range">(int * int)</param>
  /// <param name="clause">Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause</param>
  /// <returns>Constructed record.</returns>
  let genILExceptionSpec
     (range: (int * int),
      clause: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec =
    { Range = range;
      Clause = clause }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder".
  /// </summary>
  /// <param name="scopeRef">Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef</param>
  /// <param name="name">string</param>
  /// <param name="isForwarder">bool</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess</param>
  /// <param name="nested">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILExportedTypeOrForwarder
     (scopeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef,
      name: string,
      isForwarder: bool,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess,
      nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder =
    { ScopeRef = scopeRef;
      Name = name;
      IsForwarder = isForwarder;
      Access = access;
      Nested = nested;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="isStatic">bool</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess</param>
  /// <param name="data">byte[] option</param>
  /// <param name="literalValue">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option</param>
  /// <param name="offset">int option</param>
  /// <param name="isSpecialName">bool</param>
  /// <param name="marshal">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option</param>
  /// <param name="notSerialized">bool</param>
  /// <param name="isLiteral">bool</param>
  /// <param name="isInitOnly">bool</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILFieldDef
     (name: string,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      isStatic: bool,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      data: byte[] option,
      literalValue: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      offset: int option,
      isSpecialName: bool,
      marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      notSerialized: bool,
      isLiteral: bool,
      isInitOnly: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef =
    { Name = name;
      Type = _type;
      IsStatic = isStatic;
      Access = access;
      Data = data;
      LiteralValue = literalValue;
      Offset = offset;
      IsSpecialName = isSpecialName;
      Marshal = marshal;
      NotSerialized = notSerialized;
      IsLiteral = isLiteral;
      IsInitOnly = isInitOnly;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef".
  /// </summary>
  /// <param name="enclosingTypeRef">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef</param>
  /// <param name="name">string</param>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed record.</returns>
  let genILFieldRef
     (enclosingTypeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef,
      name: string,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef =
    { EnclosingTypeRef = enclosingTypeRef;
      Name = name;
      Type = _type }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec".
  /// </summary>
  /// <param name="fieldRef">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef</param>
  /// <param name="enclosingType">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed record.</returns>
  let genILFieldSpec
     (fieldRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef,
      enclosingType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec =
    { FieldRef = fieldRef;
      EnclosingType = enclosingType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="constraints">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list</param>
  /// <param name="variance">Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance</param>
  /// <param name="hasReferenceTypeConstraint">bool</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <param name="hasNotNullableValueTypeConstraint">bool</param>
  /// <param name="hasDefaultConstructorConstraint">bool</param>
  /// <returns>Constructed record.</returns>
  let genILGenericParameterDef
     (name: string,
      constraints: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      variance: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance,
      hasReferenceTypeConstraint: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      hasNotNullableValueTypeConstraint: bool,
      hasDefaultConstructorConstraint: bool)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef =
    { Name = name;
      Constraints = constraints;
      Variance = variance;
      HasReferenceTypeConstraint = hasReferenceTypeConstraint;
      CustomAttrs = customAttrs;
      HasNotNullableValueTypeConstraint = hasNotNullableValueTypeConstraint;
      HasDefaultConstructorConstraint = hasDefaultConstructorConstraint }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal".
  /// </summary>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="isPinned">bool</param>
  /// <param name="debugInfo">(string * int * int) option</param>
  /// <returns>Constructed record.</returns>
  let genILLocal
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      isPinned: bool,
      debugInfo: (string * int * int) option)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal =
    { Type = _type;
      IsPinned = isPinned;
      DebugInfo = debugInfo }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo".
  /// </summary>
  /// <param name="range">(int * int)</param>
  /// <param name="debugMappings">Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping list</param>
  /// <returns>Constructed record.</returns>
  let genILLocalDebugInfo
     (range: (int * int),
      debugMappings: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping list)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo =
    { Range = range;
      DebugMappings = debugMappings }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping".
  /// </summary>
  /// <param name="localIndex">int</param>
  /// <param name="localName">string</param>
  /// <returns>Constructed record.</returns>
  let genILLocalDebugMapping
     (localIndex: int,
      localName: string)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping =
    { LocalIndex = localIndex;
      LocalName = localName }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody".
  /// </summary>
  /// <param name="isZeroInit">bool</param>
  /// <param name="maxStack">int</param>
  /// <param name="noInlining">bool</param>
  /// <param name="locals">Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal list</param>
  /// <param name="code">Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode</param>
  /// <param name="sourceMarker">Microsoft.FSharp.Compiler.AbstractIL.IL.ILSourceMarker option</param>
  /// <returns>Constructed record.</returns>
  let genILMethodBody
     (isZeroInit: bool,
      maxStack: int,
      noInlining: bool,
      locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal list,
      code: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode,
      sourceMarker: Microsoft.FSharp.Compiler.AbstractIL.IL.ILSourceMarker option)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody =
    { IsZeroInit = isZeroInit;
      MaxStack = maxStack;
      NoInlining = noInlining;
      Locals = locals;
      Code = code;
      SourceMarker = sourceMarker }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="mdKind">Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind</param>
  /// <param name="callingConv">Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv</param>
  /// <param name="parameters">Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter list</param>
  /// <param name="_return">Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess</param>
  /// <param name="mdBody">Microsoft.FSharp.Compiler.AbstractIL.IL.ILLazyMethodBody</param>
  /// <param name="mdCodeKind">Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind</param>
  /// <param name="isInternalCall">bool</param>
  /// <param name="isManaged">bool</param>
  /// <param name="isForwardRef">bool</param>
  /// <param name="securityDecls">Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions</param>
  /// <param name="hasSecurity">bool</param>
  /// <param name="isEntryPoint">bool</param>
  /// <param name="isReqSecObj">bool</param>
  /// <param name="isHideBySig">bool</param>
  /// <param name="isSpecialName">bool</param>
  /// <param name="isUnmanagedExport">bool</param>
  /// <param name="isSynchronized">bool</param>
  /// <param name="isPreserveSig">bool</param>
  /// <param name="isMustRun">bool</param>
  /// <param name="isNoInline">bool</param>
  /// <param name="genericParams">Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILMethodDef
     (name: string,
      mdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv,
      parameters: Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter list,
      _return: Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      mdBody: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLazyMethodBody,
      mdCodeKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind,
      isInternalCall: bool,
      isManaged: bool,
      isForwardRef: bool,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      hasSecurity: bool,
      isEntryPoint: bool,
      isReqSecObj: bool,
      isHideBySig: bool,
      isSpecialName: bool,
      isUnmanagedExport: bool,
      isSynchronized: bool,
      isPreserveSig: bool,
      isMustRun: bool,
      isNoInline: bool,
      genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef =
    { Name = name;
      mdKind = mdKind;
      CallingConv = callingConv;
      Parameters = parameters;
      Return = _return;
      Access = access;
      mdBody = mdBody;
      mdCodeKind = mdCodeKind;
      IsInternalCall = isInternalCall;
      IsManaged = isManaged;
      IsForwardRef = isForwardRef;
      SecurityDecls = securityDecls;
      HasSecurity = hasSecurity;
      IsEntryPoint = isEntryPoint;
      IsReqSecObj = isReqSecObj;
      IsHideBySig = isHideBySig;
      IsSpecialName = isSpecialName;
      IsUnmanagedExport = isUnmanagedExport;
      IsSynchronized = isSynchronized;
      IsPreserveSig = isPreserveSig;
      IsMustRun = isMustRun;
      IsNoInline = isNoInline;
      GenericParams = genericParams;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef".
  /// </summary>
  /// <param name="overrides">Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec</param>
  /// <param name="overrideBy">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <returns>Constructed record.</returns>
  let genILMethodImplDef
     (overrides: Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec,
      overrideBy: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef =
    { Overrides = overrides;
      OverrideBy = overrideBy }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo".
  /// </summary>
  /// <param name="isFinal">bool</param>
  /// <param name="isNewSlot">bool</param>
  /// <param name="isCheckAccessOnOverride">bool</param>
  /// <param name="isAbstract">bool</param>
  /// <returns>Constructed record.</returns>
  let genILMethodVirtualInfo
     (isFinal: bool,
      isNewSlot: bool,
      isCheckAccessOnOverride: bool,
      isAbstract: bool)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo =
    { IsFinal = isFinal;
      IsNewSlot = isNewSlot;
      IsCheckAccessOnOverride = isCheckAccessOnOverride;
      IsAbstract = isAbstract }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef".
  /// </summary>
  /// <param name="manifest">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest option</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <param name="name">string</param>
  /// <param name="typeDefs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs</param>
  /// <param name="subsystemVersion">(int * int)</param>
  /// <param name="useHighEntropyVA">bool</param>
  /// <param name="subSystemFlags">int</param>
  /// <param name="isDLL">bool</param>
  /// <param name="isILOnly">bool</param>
  /// <param name="platform">Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform option</param>
  /// <param name="stackReserveSize">int option</param>
  /// <param name="is32Bit">bool</param>
  /// <param name="is32BitPreferred">bool</param>
  /// <param name="is64Bit">bool</param>
  /// <param name="virtualAlignment">int</param>
  /// <param name="physicalAlignment">int</param>
  /// <param name="imageBase">int</param>
  /// <param name="metadataVersion">string</param>
  /// <param name="resources">Microsoft.FSharp.Compiler.AbstractIL.IL.ILResources</param>
  /// <param name="nativeResources">System.Lazy&lt;byte[]&gt; list</param>
  /// <returns>Constructed record.</returns>
  let genILModuleDef
     (manifest: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest option,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      name: string,
      typeDefs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs,
      subsystemVersion: (int * int),
      useHighEntropyVA: bool,
      subSystemFlags: int,
      isDLL: bool,
      isILOnly: bool,
      platform: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform option,
      stackReserveSize: int option,
      is32Bit: bool,
      is32BitPreferred: bool,
      is64Bit: bool,
      virtualAlignment: int,
      physicalAlignment: int,
      imageBase: int,
      metadataVersion: string,
      resources: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResources,
      nativeResources: System.Lazy<byte[]> list)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef =
    { Manifest = manifest;
      CustomAttrs = customAttrs;
      Name = name;
      TypeDefs = typeDefs;
      SubsystemVersion = subsystemVersion;
      UseHighEntropyVA = useHighEntropyVA;
      SubSystemFlags = subSystemFlags;
      IsDLL = isDLL;
      IsILOnly = isILOnly;
      Platform = platform;
      StackReserveSize = stackReserveSize;
      Is32Bit = is32Bit;
      Is32BitPreferred = is32BitPreferred;
      Is64Bit = is64Bit;
      VirtualAlignment = virtualAlignment;
      PhysicalAlignment = physicalAlignment;
      ImageBase = imageBase;
      MetadataVersion = metadataVersion;
      Resources = resources;
      NativeResources = nativeResources }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess</param>
  /// <param name="nested">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILNestedExportedType
     (name: string,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType =
    { Name = name;
      Access = access;
      Nested = nested;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter".
  /// </summary>
  /// <param name="name">string option</param>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="_default">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option</param>
  /// <param name="marshal">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option</param>
  /// <param name="isIn">bool</param>
  /// <param name="isOut">bool</param>
  /// <param name="isOptional">bool</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILParameter
     (name: string option,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      _default: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      isIn: bool,
      isOut: bool,
      isOptional: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter =
    { Name = name;
      Type = _type;
      Default = _default;
      Marshal = marshal;
      IsIn = isIn;
      IsOut = isOut;
      IsOptional = isOptional;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="isRTSpecialName">bool</param>
  /// <param name="isSpecialName">bool</param>
  /// <param name="setMethod">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option</param>
  /// <param name="getMethod">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option</param>
  /// <param name="callingConv">Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention</param>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="init">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option</param>
  /// <param name="args">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILPropertyDef
     (name: string,
      isRTSpecialName: bool,
      isSpecialName: bool,
      setMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      getMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      init: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      args: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef =
    { Name = name;
      IsRTSpecialName = isRTSpecialName;
      IsSpecialName = isSpecialName;
      SetMethod = setMethod;
      GetMethod = getMethod;
      CallingConv = callingConv;
      Type = _type;
      Init = init;
      Args = args;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences".
  /// </summary>
  /// <param name="assemblyReferences">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyRef list</param>
  /// <param name="moduleReferences">Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef list</param>
  /// <returns>Constructed record.</returns>
  let genILReferences
     (assemblyReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyRef list,
      moduleReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef list)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences =
    { AssemblyReferences = assemblyReferences;
      ModuleReferences = moduleReferences }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="location">Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILResource
     (name: string,
      location: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource =
    { Name = name;
      Location = location;
      Access = access;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn".
  /// </summary>
  /// <param name="marshal">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option</param>
  /// <param name="_type">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILReturn
     (marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn =
    { Marshal = marshal;
      Type = _type;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef".
  /// </summary>
  /// <param name="tdKind">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind</param>
  /// <param name="name">string</param>
  /// <param name="genericParams">Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list</param>
  /// <param name="access">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess</param>
  /// <param name="isAbstract">bool</param>
  /// <param name="isSealed">bool</param>
  /// <param name="isSerializable">bool</param>
  /// <param name="isComInterop">bool</param>
  /// <param name="layout">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout</param>
  /// <param name="isSpecialName">bool</param>
  /// <param name="encoding">Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding</param>
  /// <param name="nestedTypes">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs</param>
  /// <param name="implements">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list</param>
  /// <param name="extends">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option</param>
  /// <param name="methods">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDefs</param>
  /// <param name="securityDecls">Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions</param>
  /// <param name="hasSecurity">bool</param>
  /// <param name="fields">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDefs</param>
  /// <param name="methodImpls">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDefs</param>
  /// <param name="initSemantics">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit</param>
  /// <param name="events">Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDefs</param>
  /// <param name="properties">Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDefs</param>
  /// <param name="customAttrs">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes</param>
  /// <returns>Constructed record.</returns>
  let genILTypeDef
     (tdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind,
      name: string,
      genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess,
      isAbstract: bool,
      isSealed: bool,
      isSerializable: bool,
      isComInterop: bool,
      layout: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout,
      isSpecialName: bool,
      encoding: Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding,
      nestedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs,
      implements: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      extends: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      methods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDefs,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      hasSecurity: bool,
      fields: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDefs,
      methodImpls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDefs,
      initSemantics: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit,
      events: Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDefs,
      properties: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDefs,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef =
    { tdKind = tdKind;
      Name = name;
      GenericParams = genericParams;
      Access = access;
      IsAbstract = isAbstract;
      IsSealed = isSealed;
      IsSerializable = isSerializable;
      IsComInterop = isComInterop;
      Layout = layout;
      IsSpecialName = isSpecialName;
      Encoding = encoding;
      NestedTypes = nestedTypes;
      Implements = implements;
      Extends = extends;
      Methods = methods;
      SecurityDecls = securityDecls;
      HasSecurity = hasSecurity;
      Fields = fields;
      MethodImpls = methodImpls;
      InitSemantics = initSemantics;
      Events = events;
      Properties = properties;
      CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo".
  /// </summary>
  /// <param name="size">int option</param>
  /// <param name="pack">System.UInt16 option</param>
  /// <returns>Constructed record.</returns>
  let genILTypeDefLayoutInfo
     (size: int option,
      pack: System.UInt16 option)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo =
    { Size = size;
      Pack = pack }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.InsertContext".
  /// </summary>
  /// <param name="scopeKind">Microsoft.FSharp.Compiler.SourceCodeServices.ScopeKind</param>
  /// <param name="pos">Microsoft.FSharp.Compiler.Range.pos</param>
  /// <returns>Constructed record.</returns>
  let genInsertContext
     (scopeKind: Microsoft.FSharp.Compiler.SourceCodeServices.ScopeKind,
      pos: Microsoft.FSharp.Compiler.Range.pos)
     : Microsoft.FSharp.Compiler.SourceCodeServices.InsertContext =
    { ScopeKind = scopeKind;
      Pos = pos }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.MaybeUnresolvedIdent".
  /// </summary>
  /// <param name="ident">string</param>
  /// <param name="resolved">bool</param>
  /// <returns>Constructed record.</returns>
  let genMaybeUnresolvedIdent
     (ident: string,
      resolved: bool)
     : Microsoft.FSharp.Compiler.SourceCodeServices.MaybeUnresolvedIdent =
    { Ident = ident;
      Resolved = resolved }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberFlags".
  /// </summary>
  /// <param name="isInstance">bool</param>
  /// <param name="isDispatchSlot">bool</param>
  /// <param name="isOverrideOrExplicitImpl">bool</param>
  /// <param name="isFinal">bool</param>
  /// <param name="memberKind">Microsoft.FSharp.Compiler.Ast.MemberKind</param>
  /// <returns>Constructed record.</returns>
  let genMemberFlags
     (isInstance: bool,
      isDispatchSlot: bool,
      isOverrideOrExplicitImpl: bool,
      isFinal: bool,
      memberKind: Microsoft.FSharp.Compiler.Ast.MemberKind)
     : Microsoft.FSharp.Compiler.Ast.MemberFlags =
    { IsInstance = isInstance;
      IsDispatchSlot = isDispatchSlot;
      IsOverrideOrExplicitImpl = isOverrideOrExplicitImpl;
      IsFinal = isFinal;
      MemberKind = memberKind }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.ModuleKind".
  /// </summary>
  /// <param name="isAutoOpen">bool</param>
  /// <param name="hasModuleSuffix">bool</param>
  /// <returns>Constructed record.</returns>
  let genModuleKind
     (isAutoOpen: bool,
      hasModuleSuffix: bool)
     : Microsoft.FSharp.Compiler.SourceCodeServices.ModuleKind =
    { IsAutoOpen = isAutoOpen;
      HasModuleSuffix = hasModuleSuffix }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.NavigableItem".
  /// </summary>
  /// <param name="name">string</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="isSignature">bool</param>
  /// <param name="kind">Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.NavigableItemKind</param>
  /// <param name="container">Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.Container</param>
  /// <returns>Constructed record.</returns>
  let genNavigableItem
     (name: string,
      range: Microsoft.FSharp.Compiler.Range.range,
      isSignature: bool,
      kind: Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.NavigableItemKind,
      container: Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.Container)
     : Microsoft.FSharp.Compiler.SourceCodeServices.NavigateTo.NavigableItem =
    { Name = name;
      Range = range;
      IsSignature = isSignature;
      Kind = kind;
      Container = container }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod".
  /// </summary>
  /// <param name="where">Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef</param>
  /// <param name="name">string</param>
  /// <param name="callingConv">Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention</param>
  /// <param name="charEncoding">Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding</param>
  /// <param name="noMangle">bool</param>
  /// <param name="lastError">bool</param>
  /// <param name="throwOnUnmappableChar">Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar</param>
  /// <param name="charBestFit">Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit</param>
  /// <returns>Constructed record.</returns>
  let genPInvokeMethod
     (where: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef,
      name: string,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention,
      charEncoding: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding,
      noMangle: bool,
      lastError: bool,
      throwOnUnmappableChar: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar,
      charBestFit: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit)
     : Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod =
    { Where = where;
      Name = name;
      CallingConv = callingConv;
      CharEncoding = charEncoding;
      NoMangle = noMangle;
      LastError = lastError;
      ThrowOnUnmappableChar = throwOnUnmappableChar;
      CharBestFit = charBestFit }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.PhasedDiagnostic".
  /// </summary>
  /// <param name="_exception">System.Exception</param>
  /// <param name="phase">Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase</param>
  /// <returns>Constructed record.</returns>
  let genPhasedDiagnostic
     (_exception: System.Exception,
      phase: Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase)
     : Microsoft.FSharp.Compiler.ErrorLogger.PhasedDiagnostic =
    { Exception = _exception;
      Phase = phase }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAttribute".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="argExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="target">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="appliesToGetterAndSetter">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed record.</returns>
  let genSynAttribute
     (typeName: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      target: Microsoft.FSharp.Compiler.Ast.Ident option,
      appliesToGetterAndSetter: bool,
      range: Microsoft.FSharp.Compiler.Range.range)
     : Microsoft.FSharp.Compiler.Ast.SynAttribute =
    { TypeName = typeName;
      ArgExpr = argExpr;
      Target = target;
      AppliesToGetterAndSetter = appliesToGetterAndSetter;
      Range = range }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedSymbol".
  /// </summary>
  /// <param name="displayName">string</param>
  /// <param name="_namespace">string[]</param>
  /// <returns>Constructed record.</returns>
  let genUnresolvedSymbol
     (displayName: string,
      _namespace: string[])
     : Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedSymbol =
    { DisplayName = displayName;
      Namespace = _namespace }

