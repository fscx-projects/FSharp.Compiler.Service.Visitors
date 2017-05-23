//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 23 May 2017 08:29:34 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitors

open System

/// Construct discriminal union types arguments less.
[<AutoOpen>]
module AstUnionCons =

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo.APInfo".
  /// </summary>
  /// <param name="item1">bool</param>
  /// <param name="item2">(string * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genActivePatternInfo_APInfo(item1, item2, item3) =
    Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo.APInfo
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.Invalid".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_Invalid() =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.Invalid

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.Inherit".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.SourceCodeServices.InheritanceContext</param>
  /// <param name="item2">(string list * string option)</param>
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_Inherit(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.Inherit
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.RecordField".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext</param>
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_RecordField(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.RecordField
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.RangeOperator".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_RangeOperator() =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.RangeOperator

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.ParameterList".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Range.pos</param>
  /// <param name="item2">System.Collections.Generic.HashSet&lt;string&gt;</param>
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_ParameterList(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.ParameterList
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.AttributeApplication".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_AttributeApplication() =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.AttributeApplication

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.OpenDeclaration".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genCompletionContext_OpenDeclaration() =
    Microsoft.FSharp.Compiler.SourceCodeServices.CompletionContext.OpenDeclaration

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpEntity</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration list</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpImplementationFileDeclaration_Entity(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpMemberOrFunctionOrValue</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpMemberOrFunctionOrValue list list</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpExpr</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpImplementationFileDeclaration_MemberOrFunctionOrValue(item1, item2, item3) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.InitAction".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpExpr</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpImplementationFileDeclaration_InitAction(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.InitAction
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement&lt;_&gt;.None".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_None() =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement<_>.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement&lt;_&gt;.Single".
  /// </summary>
  /// <param name="item1">_</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_Single(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement<_>.Single
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement&lt;_&gt;.SingleParameter".
  /// </summary>
  /// <param name="item1">_</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc</param>
  /// <param name="item3">string</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_SingleParameter(item1, item2, item3) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement<_>.SingleParameter
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement&lt;_&gt;.Group".
  /// </summary>
  /// <param name="item">(_ * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc) list</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_Group(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement<_>.Group
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement&lt;_&gt;.CompositionError".
  /// </summary>
  /// <param name="item">string</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_CompositionError(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement<_>.CompositionError
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.None".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genFSharpXmlDoc_None() =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.Text".
  /// </summary>
  /// <param name="item">string</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpXmlDoc_Text(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.Text
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature".
  /// </summary>
  /// <param name="item1">string</param>
  /// <param name="item2">string</param>
  /// <returns>Constructed instance.</returns>
  let genFSharpXmlDoc_XmlDocFileSignature(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.String".
  /// </summary>
  /// <param name="item">string option</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_String(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.String
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Bool".
  /// </summary>
  /// <param name="item">bool</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Bool(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Bool
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Char".
  /// </summary>
  /// <param name="item">char</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Char(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Char
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.SByte".
  /// </summary>
  /// <param name="item">System.SByte</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_SByte(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.SByte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int16".
  /// </summary>
  /// <param name="item">int16</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Int16(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int32".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Int32(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int64".
  /// </summary>
  /// <param name="item">int64</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Int64(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Byte".
  /// </summary>
  /// <param name="item">byte</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Byte(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Byte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt16".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_UInt16(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt32".
  /// </summary>
  /// <param name="item">System.UInt32</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_UInt32(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt64".
  /// </summary>
  /// <param name="item">System.UInt64</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_UInt64(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Single".
  /// </summary>
  /// <param name="item">System.Single</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Single(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Single
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Double".
  /// </summary>
  /// <param name="item">System.Double</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Double(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Double
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Null".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Null() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Null

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Type".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Type(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Type
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.TypeRef".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef option</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_TypeRef(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.TypeRef
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem list</param>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Array(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention</param>
  /// <returns>Constructed instance.</returns>
  let genILCallingConv_Callconv(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Finally".
  /// </summary>
  /// <param name="item">(int * int)</param>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_Finally(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Finally
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Fault".
  /// </summary>
  /// <param name="item">(int * int)</param>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_Fault(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Fault
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch".
  /// </summary>
  /// <param name="item1">(int * int)</param>
  /// <param name="item2">(int * int)</param>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_FilterCatch(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="item2">(int * int)</param>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_TypeCatch(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_add() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_add_ovf() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_add_ovf_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_and".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_and() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_and

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_div() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_div_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ceq".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_ceq() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ceq

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_cgt() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_cgt_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_clt() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_clt_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_conv(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_conv_ovf(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf_un".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_conv_ovf_un(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf_un
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_mul() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_mul_ovf() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_mul_ovf_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_rem() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_rem_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shl".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_shl() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_shr() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_shr_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_sub() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_sub_ovf() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf_un".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_sub_ovf_un() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_xor".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_xor() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_xor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_or".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_or() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_or

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_neg".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_neg() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_neg

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_not".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_not() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_not

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldnull".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_ldnull() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldnull

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_dup".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_dup() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_dup

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_pop".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_pop() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_pop

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ckfinite".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_ckfinite() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ckfinite

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_nop".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_nop() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_nop

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_ldc(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarg".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldarg(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarg
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarga".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldarga(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarga
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldind(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloc".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldloc(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloc
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloca".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldloca(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloca
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_starg".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_starg(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_starg
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stind(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stloc".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stloc(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stloc
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_br".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_br(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_br
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_jmp".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_jmp(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_jmp
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr</param>
  /// <param name="item2">int</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_brcmp(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_switch".
  /// </summary>
  /// <param name="item">int list</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_switch(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_switch
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ret".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ret() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ret

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list option</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_call(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list option</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_callvirt(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list option</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_callconstraint(item1, item2, item3, item4) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list option</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_calli(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldftn".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldftn(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldftn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list option</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_newobj(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_throw".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_throw() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_throw

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfinally".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_endfinally() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfinally

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfilter".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_endfilter() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfilter

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_leave".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_leave(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_leave
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_rethrow".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_rethrow() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_rethrow

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldsfld(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldfld(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsflda".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldsflda(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsflda
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldflda".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldflda(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldflda
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stsfld(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stfld(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldstr".
  /// </summary>
  /// <param name="item">string</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldstr(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldstr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_isinst".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_isinst(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_isinst
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_castclass".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_castclass(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_castclass
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldtoken".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldtoken(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldtoken
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldvirtftn".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldvirtftn(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldvirtftn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpobj".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_cpobj(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpobj
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initobj".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_initobj(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initobj
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldobj(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stobj(item1, item2, item3) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_box".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_box(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_box
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_unbox(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox_any".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_unbox_any(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox_any
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_sizeof".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_sizeof(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_sizeof
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldelem(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stelem(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly</param>
  /// <param name="item2">bool</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldelema(item1, item2, item3, item4) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldelem_any(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stelem_any(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_newarr(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldlen".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldlen() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldlen

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_mkrefany".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_mkrefany(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_mkrefany
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanytype".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_refanytype() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanytype

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanyval".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_refanyval(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanyval
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_break".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_break() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_break

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_seqpoint".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILSourceMarker</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_seqpoint(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_seqpoint
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_arglist".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_arglist() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_arglist

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_localloc".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_localloc() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_localloc

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_cpblk(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_initblk(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ilzero".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_EI_ilzero(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ilzero
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi".
  /// </summary>
  /// <param name="item1">int</param>
  /// <param name="item2">int</param>
  /// <returns>Constructed instance.</returns>
  let genILInstr_EI_ldlen_multi(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Empty".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Empty() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Empty

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom".
  /// </summary>
  /// <param name="item1">byte[]</param>
  /// <param name="item2">string</param>
  /// <param name="item3">string</param>
  /// <param name="item4">byte[]</param>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Custom(item1, item2, item3, item4) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedSysString".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_FixedSysString(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedSysString
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedArray".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_FixedArray(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedArray
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Currency".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Currency() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Currency

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_LPSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPWSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_LPWSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPWSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPTSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_LPTSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPTSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ByValStr".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_ByValStr() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ByValStr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.TBSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_TBSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.TBSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTRUCT".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_LPSTRUCT() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTRUCT

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Struct".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Struct() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Struct

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Void".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Void() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Void

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Bool".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Bool() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Bool

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int8".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Int8() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int16".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Int16() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int32".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Int32() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int64".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Int64() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Single".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Single() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Single

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Double".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Double() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Double

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Byte".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Byte() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Byte

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt16".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_UInt16() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt32".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_UInt32() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt64".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_UInt64() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option</param>
  /// <param name="item2">(int * int option) option</param>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Array(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Int() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_UInt() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Method".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Method() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Method

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.AsAny".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_AsAny() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.AsAny

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.BSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_BSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.BSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IUnknown".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_IUnknown() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IUnknown

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IDispatch".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_IDispatch() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IDispatch

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Interface".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Interface() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Interface

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Error".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Error() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Error

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant</param>
  /// <param name="item2">string option</param>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_SafeArray(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ANSIBSTR".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_ANSIBSTR() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ANSIBSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.VariantBool".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genILNativeType_VariantBool() =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.VariantBool

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <returns>Constructed instance.</returns>
  let genILOverridesSpec_OverridesSpec(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction</param>
  /// <param name="item2">byte[]</param>
  /// <returns>Constructed instance.</returns>
  let genILPermission_PermissionSet(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Local".
  /// </summary>
  /// <param name="item">(Microsoft.FSharp.Core.Unit -&gt; byte[])</param>
  /// <returns>Constructed instance.</returns>
  let genILResourceLocation_Local(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Local
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef</param>
  /// <param name="item2">int</param>
  /// <returns>Constructed instance.</returns>
  let genILResourceLocation_File(item1, item2) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Assembly".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyRef</param>
  /// <returns>Constructed instance.</returns>
  let genILResourceLocation_Assembly(item) =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Assembly
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Token".
  /// </summary>
  /// <param name="item">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <returns>Constructed instance.</returns>
  let genLexerEndlineContinuation_Token(item) =
    Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Token
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip".
  /// </summary>
  /// <param name="item1">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerEndlineContinuation_Skip(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression</param>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefAnd(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression</param>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefOr(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefNot".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression</param>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefNot(item) =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefNot
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefId".
  /// </summary>
  /// <param name="item">string</param>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefId(item) =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefId
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Token".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_Token(ifdef) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Token
      (ifdef)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_IfDefSkip(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_String(ifdef, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String
      (ifdef,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_VerbatimString(ifdef, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString
      (ifdef,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_TripleQuoteString(ifdef, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString
      (ifdef,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_Comment(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_SingleLineComment(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_StringInComment(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_VerbatimStringInComment(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment".
  /// </summary>
  /// <param name="ifdef">(Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry * Microsoft.FSharp.Compiler.Range.range) list</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_TripleQuoteStringInComment(ifdef, item2, range) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment
      (ifdef,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.EndLine".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation</param>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_EndLine(item) =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.EndLine
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LongIdentWithDots".
  /// </summary>
  /// <param name="id">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="dotms">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <returns>Constructed instance.</returns>
  let genLongIdentWithDots(id, dotms) =
    Microsoft.FSharp.Compiler.Ast.LongIdentWithDots
      (id,
       dotms)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair".
  /// </summary>
  /// <param name="item1">string</param>
  /// <param name="item2">int</param>
  /// <returns>Constructed instance.</returns>
  let genNameArityPair(item1, item2) =
    Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult&lt;_&gt;.OkResult".
  /// </summary>
  /// <param name="item1">System.Exception list</param>
  /// <param name="item2">_</param>
  /// <returns>Constructed instance.</returns>
  let genOperationResult_OkResult(item1, item2) =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.OkResult
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult&lt;_&gt;.ErrorResult".
  /// </summary>
  /// <param name="item1">System.Exception list</param>
  /// <param name="item2">System.Exception</param>
  /// <returns>Constructed instance.</returns>
  let genOperationResult_ErrorResult(item1, item2) =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.ErrorResult
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynModuleDecl list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedFsiInteraction_IDefns(item1, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedFsiInteraction_IHash(item1, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedHashDirective".
  /// </summary>
  /// <param name="item1">string</param>
  /// <param name="item2">string list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedHashDirective(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedHashDirective
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFile".
  /// </summary>
  /// <param name="hashDirectives">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment list</param>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFile(hashDirectives, item2) =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynModuleDecl list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileFragment_AnonModule(item1, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace</param>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileFragment_NamedModule(item) =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="item2">bool</param>
  /// <param name="item3">bool</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynModuleDecl list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="item6">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileFragment_NamespaceFragment(longId, item2, item3, item4, xmlDoc, item6, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
      (longId,
       item2,
       item3,
       item4,
       xmlDoc,
       item6,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput".
  /// </summary>
  /// <param name="fileName">string</param>
  /// <param name="isScript">bool</param>
  /// <param name="qualifiedNameOfFile">Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile</param>
  /// <param name="scopedPragmas">Microsoft.FSharp.Compiler.Ast.ScopedPragma list</param>
  /// <param name="hashDirectives">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list</param>
  /// <param name="modules">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace list</param>
  /// <param name="item7">(bool * bool)</param>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileInput(fileName, isScript, qualifiedNameOfFile, scopedPragmas, hashDirectives, modules, item7) =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
      (fileName,
       isScript,
       qualifiedNameOfFile,
       scopedPragmas,
       hashDirectives,
       modules,
       item7)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFile".
  /// </summary>
  /// <param name="hashDirectives">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment list</param>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFile(hashDirectives, item2) =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileFragment_AnonModule(item1, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig</param>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileFragment_NamedModule(item) =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="item2">bool</param>
  /// <param name="item3">bool</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="item6">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileFragment_NamespaceFragment(longId, item2, item3, item4, xmlDoc, item6, range) =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
      (longId,
       item2,
       item3,
       item4,
       xmlDoc,
       item6,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput".
  /// </summary>
  /// <param name="fileName">string</param>
  /// <param name="qualifiedNameOfFile">Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile</param>
  /// <param name="scopedPragmas">Microsoft.FSharp.Compiler.Ast.ScopedPragma list</param>
  /// <param name="hashDirectives">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list</param>
  /// <param name="modules">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig list</param>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileInput(fileName, qualifiedNameOfFile, scopedPragmas, hashDirectives, modules) =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
      (fileName,
       qualifiedNameOfFile,
       scopedPragmas,
       hashDirectives,
       modules)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <returns>Constructed instance.</returns>
  let genPreXmlMerge(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Range.pos</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.XmlDocCollector</param>
  /// <returns>Constructed instance.</returns>
  let genPreXmlDoc(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genPreXmlDocEmpty() =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.CopyOnUpdate".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="item2">(string list * string option)</param>
  /// <returns>Constructed instance.</returns>
  let genRecordContext_CopyOnUpdate(item1, item2) =
    Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.CopyOnUpdate
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.Constructor".
  /// </summary>
  /// <param name="item">string</param>
  /// <returns>Constructed instance.</returns>
  let genRecordContext_Constructor(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.Constructor
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.New".
  /// </summary>
  /// <param name="item">(string list * string option)</param>
  /// <returns>Constructed instance.</returns>
  let genRecordContext_New(item) =
    Microsoft.FSharp.Compiler.SourceCodeServices.RecordContext.New
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="item2">int</param>
  /// <returns>Constructed instance.</returns>
  let genScopedPragma_WarningOff(range, item2) =
    Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff
      (range,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynArgInfo".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="optional">bool</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <returns>Constructed instance.</returns>
  let genSynArgInfo(item1, optional, item3) =
    Microsoft.FSharp.Compiler.Ast.SynArgInfo
      (item1,
       optional,
       item3)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBinding.Binding".
  /// </summary>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="kind">Microsoft.FSharp.Compiler.Ast.SynBindingKind</param>
  /// <param name="mustInline">bool</param>
  /// <param name="isMutable">bool</param>
  /// <param name="attrs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="valData">Microsoft.FSharp.Compiler.Ast.SynValData</param>
  /// <param name="headPat">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="returnInfo">Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="seqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <returns>Constructed instance.</returns>
  let genSynBinding_Binding(accessibility, kind, mustInline, isMutable, attrs, xmlDoc, valData, headPat, returnInfo, expr, range, seqPoint) =
    Microsoft.FSharp.Compiler.Ast.SynBinding.Binding
      (accessibility,
       kind,
       mustInline,
       isMutable,
       attrs,
       xmlDoc,
       valData,
       headPat,
       returnInfo,
       expr,
       range,
       seqPoint)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="attributes">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <returns>Constructed instance.</returns>
  let genSynBindingReturnInfo(typeName, range, attributes) =
    Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
      (typeName,
       range,
       attributes)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo".
  /// </summary>
  /// <param name="attribs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="typeParams">Microsoft.FSharp.Compiler.Ast.SynTyparDecl list</param>
  /// <param name="constraints">Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="preferPostfix">bool</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynComponentInfo_ComponentInfo(attribs, typeParams, constraints, longId, xmlDoc, preferPostfix, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo
      (attribs,
       typeParams,
       constraints,
       longId,
       xmlDoc,
       preferPostfix,
       accessibility,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Unit".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynConst_Unit() =
    Microsoft.FSharp.Compiler.Ast.SynConst.Unit

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Bool".
  /// </summary>
  /// <param name="item">bool</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Bool(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bool
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.SByte".
  /// </summary>
  /// <param name="item">System.SByte</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_SByte(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.SByte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Byte".
  /// </summary>
  /// <param name="item">byte</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Byte(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Byte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int16".
  /// </summary>
  /// <param name="item">int16</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Int16(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt16".
  /// </summary>
  /// <param name="item">System.UInt16</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UInt16(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int32".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Int32(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt32".
  /// </summary>
  /// <param name="item">System.UInt32</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UInt32(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int64".
  /// </summary>
  /// <param name="item">int64</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Int64(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt64".
  /// </summary>
  /// <param name="item">System.UInt64</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UInt64(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr".
  /// </summary>
  /// <param name="item">int64</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_IntPtr(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr".
  /// </summary>
  /// <param name="item">System.UInt64</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UIntPtr(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Single".
  /// </summary>
  /// <param name="item">System.Single</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Single(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Single
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Double".
  /// </summary>
  /// <param name="item">System.Double</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Double(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Double
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Char".
  /// </summary>
  /// <param name="item">char</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Char(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Char
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Decimal".
  /// </summary>
  /// <param name="item">System.Decimal</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Decimal(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Decimal
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UserNum".
  /// </summary>
  /// <param name="value">string</param>
  /// <param name="suffix">string</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UserNum(value, suffix) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UserNum
      (value,
       suffix)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.String".
  /// </summary>
  /// <param name="text">string</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_String(text, range) =
    Microsoft.FSharp.Compiler.Ast.SynConst.String
      (text,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Bytes".
  /// </summary>
  /// <param name="bytes">byte[]</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Bytes(bytes, range) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bytes
      (bytes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s".
  /// </summary>
  /// <param name="item">System.UInt16[]</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_UInt16s(item) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Measure".
  /// </summary>
  /// <param name="constant">Microsoft.FSharp.Compiler.Ast.SynConst</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Measure(constant, item2) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Measure
      (constant,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynPat list</param>
  /// <returns>Constructed instance.</returns>
  let genSynConstructorArgs_Pats(item) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs".
  /// </summary>
  /// <param name="item1">(Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynConstructorArgs_NamePatPairs(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase".
  /// </summary>
  /// <param name="attrs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynConst</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynEnumCase_EnumCase(attrs, ident, item3, item4, range) =
    Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase
      (attrs,
       ident,
       item3,
       item4,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefn".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMemberDefn list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionDefn(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynUnionCase</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list option</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="accessiblity">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionDefnRepr(item1, item2, longId, xmlDoc, accessiblity, range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
      (item1,
       item2,
       longId,
       xmlDoc,
       accessiblity,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionSig".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMemberSig list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionSig(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionSig
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Paren".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="leftParenRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="rightParenRange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Paren(expr, leftParenRange, rightParenRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
      (expr,
       leftParenRange,
       rightParenRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Quote".
  /// </summary>
  /// <param name="operator">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="isRaw">bool</param>
  /// <param name="quotedSynExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="isFromQueryExpression">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
      (operator,
       isRaw,
       quotedSynExpr,
       isFromQueryExpression,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Const".
  /// </summary>
  /// <param name="constant">Microsoft.FSharp.Compiler.Ast.SynConst</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Const(constant, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Typed".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Typed(expr, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple".
  /// </summary>
  /// <param name="exprs">Microsoft.FSharp.Compiler.Ast.SynExpr list</param>
  /// <param name="commaRanges">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Tuple(exprs, commaRanges, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
      (exprs,
       commaRanges,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.StructTuple".
  /// </summary>
  /// <param name="exprs">Microsoft.FSharp.Compiler.Ast.SynExpr list</param>
  /// <param name="commaRanges">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_StructTuple(exprs, commaRanges, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.StructTuple
      (exprs,
       commaRanges,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList".
  /// </summary>
  /// <param name="isList">bool</param>
  /// <param name="exprs">Microsoft.FSharp.Compiler.Ast.SynExpr list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArrayOrList(isList, exprs, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
      (isList,
       exprs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Record".
  /// </summary>
  /// <param name="baseInfo">(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option</param>
  /// <param name="copyInfo">(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option</param>
  /// <param name="recordFields">((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Record(baseInfo, copyInfo, recordFields, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record
      (baseInfo,
       copyInfo,
       recordFields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.New".
  /// </summary>
  /// <param name="isProtected">bool</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_New(isProtected, typeName, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New
      (isProtected,
       typeName,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr".
  /// </summary>
  /// <param name="objType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="argOptions">(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option</param>
  /// <param name="bindings">Microsoft.FSharp.Compiler.Ast.SynBinding list</param>
  /// <param name="extraImpls">Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list</param>
  /// <param name="newExprRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ObjExpr(objType, argOptions, bindings, extraImpls, newExprRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
      (objType,
       argOptions,
       bindings,
       extraImpls,
       newExprRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.While".
  /// </summary>
  /// <param name="whileSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop</param>
  /// <param name="whileExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="doExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_While(whileSeqPoint, whileExpr, doExpr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While
      (whileSeqPoint,
       whileExpr,
       doExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.For".
  /// </summary>
  /// <param name="forSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop</param>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="identBody">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item4">bool</param>
  /// <param name="toBody">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="doBody">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_For(forSeqPoint, ident, identBody, item4, toBody, doBody, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For
      (forSeqPoint,
       ident,
       identBody,
       item4,
       toBody,
       doBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach".
  /// </summary>
  /// <param name="forSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop</param>
  /// <param name="seqExprOnly">Microsoft.FSharp.Compiler.Ast.SeqExprOnly</param>
  /// <param name="isFromSource">bool</param>
  /// <param name="pat">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="enumExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="bodyExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ForEach(forSeqPoint, seqExprOnly, isFromSource, pat, enumExpr, bodyExpr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
      (forSeqPoint,
       seqExprOnly,
       isFromSource,
       pat,
       enumExpr,
       bodyExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr".
  /// </summary>
  /// <param name="isList">bool</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArrayOrListOfSeqExpr(isList, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
      (isList,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr".
  /// </summary>
  /// <param name="isArrayOrList">bool</param>
  /// <param name="isNotNakedRefCell">bool ref</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
      (isArrayOrList,
       isNotNakedRefCell,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda".
  /// </summary>
  /// <param name="fromMethod">bool</param>
  /// <param name="inLambdaSeq">bool</param>
  /// <param name="args">Microsoft.FSharp.Compiler.Ast.SynSimplePats</param>
  /// <param name="body">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Lambda(fromMethod, inLambdaSeq, args, body, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
      (fromMethod,
       inLambdaSeq,
       args,
       body,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda".
  /// </summary>
  /// <param name="isExnMatch">bool</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynMatchClause list</param>
  /// <param name="matchSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_MatchLambda(isExnMatch, item2, item3, matchSeqPoint, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
      (isExnMatch,
       item2,
       item3,
       matchSeqPoint,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Match".
  /// </summary>
  /// <param name="matchSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="clauses">Microsoft.FSharp.Compiler.Ast.SynMatchClause list</param>
  /// <param name="isExnMatch">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Match(matchSeqPoint, expr, clauses, isExnMatch, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match
      (matchSeqPoint,
       expr,
       clauses,
       isExnMatch,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Do".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Do(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Assert".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Assert(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.App".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag</param>
  /// <param name="isInfix">bool</param>
  /// <param name="funcExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="argExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_App(item1, isInfix, funcExpr, argExpr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (item1,
       isInfix,
       funcExpr,
       argExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="lESSrange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="typeNames">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="commaRanges">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <param name="gREATERrange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="typeArgsRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TypeApp(expr, lESSrange, typeNames, commaRanges, gREATERrange, typeArgsRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
      (expr,
       lESSrange,
       typeNames,
       commaRanges,
       gREATERrange,
       typeArgsRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse".
  /// </summary>
  /// <param name="isRecursive">bool</param>
  /// <param name="isUse">bool</param>
  /// <param name="bindings">Microsoft.FSharp.Compiler.Ast.SynBinding list</param>
  /// <param name="body">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LetOrUse(isRecursive, isUse, bindings, body, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
      (isRecursive,
       isUse,
       bindings,
       body,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith".
  /// </summary>
  /// <param name="tryExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="tryRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="withCases">Microsoft.FSharp.Compiler.Ast.SynMatchClause list</param>
  /// <param name="withRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="trySeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry</param>
  /// <param name="withSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TryWith(tryExpr, tryRange, withCases, withRange, range, trySeqPoint, withSeqPoint) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
      (tryExpr,
       tryRange,
       withCases,
       withRange,
       range,
       trySeqPoint,
       withSeqPoint)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally".
  /// </summary>
  /// <param name="tryExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="finallyExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="trySeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry</param>
  /// <param name="finallySeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TryFinally(tryExpr, finallyExpr, range, trySeqPoint, finallySeqPoint) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
      (tryExpr,
       finallyExpr,
       range,
       trySeqPoint,
       finallySeqPoint)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Lazy(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential".
  /// </summary>
  /// <param name="seqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq</param>
  /// <param name="isTrueSeq">bool</param>
  /// <param name="expr1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="expr2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Sequential(seqPoint, isTrueSeq, expr1, expr2, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
      (seqPoint,
       isTrueSeq,
       expr1,
       expr2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse".
  /// </summary>
  /// <param name="ifExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="thenExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="elseExpr">Microsoft.FSharp.Compiler.Ast.SynExpr option</param>
  /// <param name="spIfToThen">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <param name="isFromErrorRecovery">bool</param>
  /// <param name="ifToThenRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_IfThenElse(ifExpr, thenExpr, elseExpr, spIfToThen, isFromErrorRecovery, ifToThenRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
      (ifExpr,
       thenExpr,
       elseExpr,
       spIfToThen,
       isFromErrorRecovery,
       ifToThenRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Ident".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Ident(item) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent".
  /// </summary>
  /// <param name="isOptional">bool</param>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="altNameRefCell">Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LongIdent(isOptional, longDotId, altNameRefCell, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent
      (isOptional,
       longDotId,
       altNameRefCell,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet".
  /// </summary>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LongIdentSet(longDotId, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
      (longDotId,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="rangeOfDot">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotGet(expr, rangeOfDot, longDotId, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
      (expr,
       rangeOfDot,
       longDotId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotSet(item1, longDotId, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
      (item1,
       longDotId,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynIndexerArg list</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotIndexedGet(item1, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet".
  /// </summary>
  /// <param name="objectExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="indexExprs">Microsoft.FSharp.Compiler.Ast.SynIndexerArg list</param>
  /// <param name="valueExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="leftOfSetRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="dotRange">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotIndexedSet(objectExpr, indexExprs, valueExpr, leftOfSetRange, dotRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
      (objectExpr,
       indexExprs,
       valueExpr,
       leftOfSetRange,
       dotRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet".
  /// </summary>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_NamedIndexedPropertySet(longDotId, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
      (longDotId,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotNamedIndexedPropertySet(item1, longDotId, item3, item4, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
      (item1,
       longDotId,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TypeTest(expr, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Upcast(expr, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Downcast(expr, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_InferredUpcast(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_InferredDowncast(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Null".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Null(range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf".
  /// </summary>
  /// <param name="isByref">bool</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_AddressOf(isByref, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
      (isByref,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypar list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMemberSig</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TraitCall(item1, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_JoinIn(item1, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ImplicitZero(range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn".
  /// </summary>
  /// <param name="item1">(bool * bool)</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_YieldOrReturn(item1, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <param name="item1">(bool * bool)</param>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_YieldOrReturnFrom(item1, expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang".
  /// </summary>
  /// <param name="bindSeqPoint">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <param name="isUse">bool</param>
  /// <param name="isFromSource">bool</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item5">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item6">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LetOrUseBang(bindSeqPoint, isUse, isFromSource, item4, item5, item6, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
      (bindSeqPoint,
       isUse,
       isFromSource,
       item4,
       item5,
       item6,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DoBang(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[]</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr list</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyILAssembly(item1, item2, item3, item4, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
      (item1,
       item2,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyStaticOptimization(item1, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="item3">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyUnionCaseFieldGet(expr, longId, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
      (expr,
       longId,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="item3">int</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
      (item1,
       longId,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <param name="debugStr">string</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArbitraryAfterError(debugStr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError
      (debugStr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_FromParseError(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DiscardAfterMissingQualificationAfterDot(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Fixed(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
      (expr,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynField.Field".
  /// </summary>
  /// <param name="attrs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="isStatic">bool</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item5">bool</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynField_Field(attrs, isStatic, item3, item4, item5, xmlDoc, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynField.Field
      (attrs,
       isStatic,
       item3,
       item4,
       item5,
       xmlDoc,
       accessibility,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <returns>Constructed instance.</returns>
  let genSynIndexerArg_Two(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <returns>Constructed instance.</returns>
  let genSynIndexerArg_One(item) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynBinding list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynInterfaceImpl_InterfaceImpl(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr option</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <param name="item5">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget</param>
  /// <returns>Constructed instance.</returns>
  let genSynMatchClause_Clause(item1, item2, item3, range, item5) =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
      (item1,
       item2,
       item3,
       range,
       item5)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Named".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Named(longId, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Named
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Product".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Product(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynMeasure list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Seq(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Divide(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Power".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynMeasure</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynRationalConst</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Power(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.One".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_One() =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.One

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Anon(range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Var".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Var(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Open(longId, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member".
  /// </summary>
  /// <param name="memberDefn">Microsoft.FSharp.Compiler.Ast.SynBinding</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Member(memberDefn, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
      (memberDefn,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor".
  /// </summary>
  /// <param name="accessiblity">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="attributes">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="ctorArgs">Microsoft.FSharp.Compiler.Ast.SynSimplePat list</param>
  /// <param name="selfIdentifier">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
      (accessiblity,
       attributes,
       ctorArgs,
       selfIdentifier,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit".
  /// </summary>
  /// <param name="inheritType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="inheritArgs">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="inheritAlias">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
      (inheritType,
       inheritArgs,
       inheritAlias,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynBinding list</param>
  /// <param name="isStatic">bool</param>
  /// <param name="isRecursive">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_LetBindings(item1, isStatic, isRecursive, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
      (item1,
       isStatic,
       isRecursive,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynValSig</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.MemberFlags</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_AbstractSlot(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Interface(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Inherit(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynField</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ValField(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType".
  /// </summary>
  /// <param name="typeDefn">Microsoft.FSharp.Compiler.Ast.SynTypeDefn</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_NestedType(typeDefn, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
      (typeDefn,
       accessibility,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty".
  /// </summary>
  /// <param name="attribs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="isStatic">bool</param>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="typeOpt">Microsoft.FSharp.Compiler.Ast.SynType option</param>
  /// <param name="propKind">Microsoft.FSharp.Compiler.Ast.MemberKind</param>
  /// <param name="memberFlags">(Microsoft.FSharp.Compiler.Ast.MemberKind -&gt; Microsoft.FSharp.Compiler.Ast.MemberFlags)</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="accessiblity">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="synExpr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="getSetRange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_AutoProperty(attribs, isStatic, ident, typeOpt, propKind, memberFlags, xmlDoc, accessiblity, synExpr, getSetRange, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
      (attribs,
       isStatic,
       ident,
       typeOpt,
       propKind,
       memberFlags,
       xmlDoc,
       accessiblity,
       synExpr,
       getSetRange,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynValSig</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.MemberFlags</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Member(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Interface(typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Inherit(typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynField</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_ValField(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_NestedType(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev".
  /// </summary>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_ModuleAbbrev(ident, longId, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev
      (ident,
       longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynComponentInfo</param>
  /// <param name="isRecursive">bool</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynModuleDecl list</param>
  /// <param name="item4">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_NestedModule(item1, isRecursive, item3, item4, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
      (item1,
       isRecursive,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let".
  /// </summary>
  /// <param name="item1">bool</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynBinding list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Let(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_DoExpr(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefn list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Types(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExceptionDefn</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Exception(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open".
  /// </summary>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Open(longDotId, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open
      (longDotId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Attributes(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_HashDirective(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_NamespaceFragment(item) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="isRecursive">bool</param>
  /// <param name="isModule">bool</param>
  /// <param name="decls">Microsoft.FSharp.Compiler.Ast.SynModuleDecl list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="attribs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleOrNamespace(longId, isRecursive, isModule, decls, xmlDoc, attribs, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
      (longId,
       isRecursive,
       isModule,
       decls,
       xmlDoc,
       attribs,
       accessibility,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="isRecursive">bool</param>
  /// <param name="isModule">bool</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="attribs">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleOrNamespaceSig(longId, isRecursive, isModule, item4, xmlDoc, attribs, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
      (longId,
       isRecursive,
       isModule,
       item4,
       xmlDoc,
       attribs,
       accessibility,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev".
  /// </summary>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_ModuleAbbrev(ident, longId, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev
      (ident,
       longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynComponentInfo</param>
  /// <param name="isRecursive">bool</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_NestedModule(item1, isRecursive, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
      (item1,
       isRecursive,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynValSig</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Val(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Types(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExceptionSig</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Exception(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open".
  /// </summary>
  /// <param name="longId">Microsoft.FSharp.Compiler.Ast.Ident list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Open(longId, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.ParsedHashDirective</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_HashDirective(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig</param>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_NamespaceFragment(item) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Const".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynConst</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Const(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Const
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Wild".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Wild(range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Wild
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Named".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="isSelfIdentifier">bool</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Named(item1, item2, isSelfIdentifier, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Named
      (item1,
       item2,
       isSelfIdentifier,
       accessibility,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Typed".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Typed(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Typed
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Attrib".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Attrib(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Or".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Or(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Or
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Ands".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Ands(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Ands
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent".
  /// </summary>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynConstructorArgs</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_LongIdent(longDotId, item2, item3, item4, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
      (longDotId,
       item2,
       item3,
       item4,
       accessibility,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Tuple".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Tuple(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.StructTuple".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_StructTuple(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.StructTuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Paren".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Paren(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Paren
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList".
  /// </summary>
  /// <param name="item1">bool</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynPat list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_ArrayOrList(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Record".
  /// </summary>
  /// <param name="item1">((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Record(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Record
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Null".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Null(range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Null
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_OptionalVal(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.IsInst".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_IsInst(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_QuoteExpr(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange".
  /// </summary>
  /// <param name="item1">char</param>
  /// <param name="item2">char</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_DeprecatedCharRange(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_InstanceMember(item1, item2, item3, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
      (item1,
       item2,
       item3,
       accessibility,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynPat</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynPat_FromParseError(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer".
  /// </summary>
  /// <param name="item">int</param>
  /// <returns>Constructed instance.</returns>
  let genSynRationalConst_Integer(item) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational".
  /// </summary>
  /// <param name="item1">int</param>
  /// <param name="item2">int</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynRationalConst_Rational(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynRationalConst</param>
  /// <returns>Constructed instance.</returns>
  let genSynRationalConst_Negate(item) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynReturnInfo".
  /// </summary>
  /// <param name="item1">(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo)</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynReturnInfo(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynReturnInfo
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id".
  /// </summary>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="altNameRefCell">Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option</param>
  /// <param name="isCompilerGenerated">bool</param>
  /// <param name="isThisVar">bool</param>
  /// <param name="isOptArg">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
      (ident,
       altNameRefCell,
       isCompilerGenerated,
       isThisVar,
       isOptArg,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynSimplePat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Typed(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynSimplePat</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Attrib(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynSimplePat list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePats_SimplePats(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynSimplePats</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePats_Typed(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynStaticOptimizationConstraint_WhenTyparIsStruct(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
      (item1,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypar.Typar".
  /// </summary>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="staticReq">Microsoft.FSharp.Compiler.Ast.TyparStaticReq</param>
  /// <param name="isCompGen">bool</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypar_Typar(ident, staticReq, isCompGen) =
    Microsoft.FSharp.Compiler.Ast.SynTypar.Typar
      (ident,
       staticReq,
       isCompGen)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl".
  /// </summary>
  /// <param name="attributes">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <returns>Constructed instance.</returns>
  let genSynTyparDecl_TyparDecl(attributes, item2) =
    Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
      (attributes,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.LongIdent".
  /// </summary>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_LongIdent(longDotId) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdent
      (longDotId)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.App".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="lESSrange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="typeArgs">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="commaRanges">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <param name="gREATERrange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="isPostfix">bool</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_App(typeName, lESSrange, typeArgs, commaRanges, gREATERrange, isPostfix, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.App
      (typeName,
       lESSrange,
       typeArgs,
       commaRanges,
       gREATERrange,
       isPostfix,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="longDotId">Microsoft.FSharp.Compiler.Ast.LongIdentWithDots</param>
  /// <param name="lESSRange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="typeArgs">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="commaRanges">Microsoft.FSharp.Compiler.Range.range list</param>
  /// <param name="gREATERrange">Microsoft.FSharp.Compiler.Range.range option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_LongIdentApp(typeName, longDotId, lESSRange, typeArgs, commaRanges, gREATERrange, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
      (typeName,
       longDotId,
       lESSRange,
       typeArgs,
       commaRanges,
       gREATERrange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Tuple".
  /// </summary>
  /// <param name="typeNames">(bool * Microsoft.FSharp.Compiler.Ast.SynType) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_Tuple(typeNames, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Tuple
      (typeNames,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StructTuple".
  /// </summary>
  /// <param name="typeNames">(bool * Microsoft.FSharp.Compiler.Ast.SynType) list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_StructTuple(typeNames, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StructTuple
      (typeNames,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Array".
  /// </summary>
  /// <param name="item1">int</param>
  /// <param name="elementType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_Array(item1, elementType, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Array
      (item1,
       elementType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Fun".
  /// </summary>
  /// <param name="argType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="returnType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_Fun(argType, returnType, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Fun
      (argType,
       returnType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Var".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_Var(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Var
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Anon".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_Anon(range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Anon
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints".
  /// </summary>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="constraints">Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_WithGlobalConstraints(typeName, constraints, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
      (typeName,
       constraints,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_HashConstraint(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide".
  /// </summary>
  /// <param name="dividendType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="divisorType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_MeasureDivide(dividendType, divisorType, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
      (dividendType,
       divisorType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower".
  /// </summary>
  /// <param name="measureType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynRationalConst</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_MeasurePower(measureType, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
      (measureType,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant".
  /// </summary>
  /// <param name="constant">Microsoft.FSharp.Compiler.Ast.SynConst</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstant(constant, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynExpr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstantExpr(expr, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed".
  /// </summary>
  /// <param name="expr">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstantNamed(expr, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
      (expr,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsValueType(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsReferenceType(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsUnmanaged(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSupportsNull(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsComparable(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsEquatable(genericName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparDefaultsToType(genericName, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
      (genericName,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="typeName">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSubtypeOfType(genericName, typeName, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
      (genericName,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember".
  /// </summary>
  /// <param name="genericNames">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="memberSig">Microsoft.FSharp.Compiler.Ast.SynMemberSig</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSupportsMember(genericNames, memberSig, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
      (genericNames,
       memberSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsEnum(genericName, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
      (genericName,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate".
  /// </summary>
  /// <param name="genericName">Microsoft.FSharp.Compiler.Ast.SynTypar</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsDelegate(genericName, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
      (genericName,
       item2,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynComponentInfo</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr</param>
  /// <param name="members">Microsoft.FSharp.Compiler.Ast.SynMemberDefn list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefn_TypeDefn(item1, item2, members, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
      (item1,
       item2,
       members,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconUnspecified() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconClass() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconInterface() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconStruct() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconRecord() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconUnion() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconAbbrev() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconHiddenRepr() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconAugmentation() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode".
  /// </summary>
  
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconILAssemblyCode() =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynValInfo</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconDelegate(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynMemberDefn list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnRepr_ObjectModel(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnRepr_Simple(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnRepr_Exception(item) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynComponentInfo</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynMemberSig list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSig_TypeDefnSig(item1, item2, item3, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig
      (item1,
       item2,
       item3,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind</param>
  /// <param name="memberSigs">Microsoft.FSharp.Compiler.Ast.SynMemberSig list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSigRepr_ObjectModel(item1, memberSigs, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
      (item1,
       memberSigs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSigRepr_Simple(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSigRepr_Exception(item) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union".
  /// </summary>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="unionCases">Microsoft.FSharp.Compiler.Ast.SynUnionCase list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Union(accessibility, unionCases, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
      (accessibility,
       unionCases,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynEnumCase list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Enum(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record".
  /// </summary>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="recordFields">Microsoft.FSharp.Compiler.Ast.SynField list</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Record(accessibility, recordFields, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
      (accessibility,
       recordFields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind</param>
  /// <param name="item2">(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list</param>
  /// <param name="item3">(Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.SynField list</param>
  /// <param name="item5">bool</param>
  /// <param name="item6">bool</param>
  /// <param name="item7">Microsoft.FSharp.Compiler.Ast.SynSimplePat list option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_General(item1, item2, item3, item4, item5, item6, item7, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
      (item1,
       item2,
       item3,
       item4,
       item5,
       item6,
       item7,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.AbstractIL.IL.ILType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_LibraryOnlyILAssembly(item1, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.ParserDetail</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_TypeAbbrev(item1, item2, range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None".
  /// </summary>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_None(range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception".
  /// </summary>
  /// <param name="item">Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr</param>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Exception(item) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
      (item)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.SynUnionCaseType</param>
  /// <param name="item4">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynUnionCase_UnionCase(item1, ident, item3, item4, accessibility, range) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
      (item1,
       ident,
       item3,
       item4,
       accessibility,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValData".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.MemberFlags option</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynValInfo</param>
  /// <param name="item3">Microsoft.FSharp.Compiler.Ast.Ident option</param>
  /// <returns>Constructed instance.</returns>
  let genSynValData(item1, item2, item3) =
    Microsoft.FSharp.Compiler.Ast.SynValData
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValInfo".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynArgInfo list list</param>
  /// <param name="item2">Microsoft.FSharp.Compiler.Ast.SynArgInfo</param>
  /// <returns>Constructed instance.</returns>
  let genSynValInfo(item1, item2) =
    Microsoft.FSharp.Compiler.Ast.SynValInfo
      (item1,
       item2)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn".
  /// </summary>
  /// <param name="synAttributes">Microsoft.FSharp.Compiler.Ast.SynAttribute list</param>
  /// <param name="ident">Microsoft.FSharp.Compiler.Ast.Ident</param>
  /// <param name="explicitValDecls">Microsoft.FSharp.Compiler.Ast.SynValTyparDecls</param>
  /// <param name="synType">Microsoft.FSharp.Compiler.Ast.SynType</param>
  /// <param name="arity">Microsoft.FSharp.Compiler.Ast.SynValInfo</param>
  /// <param name="isInline">bool</param>
  /// <param name="isMutable">bool</param>
  /// <param name="xmlDoc">Microsoft.FSharp.Compiler.Ast.PreXmlDoc</param>
  /// <param name="accessibility">Microsoft.FSharp.Compiler.Ast.SynAccess option</param>
  /// <param name="synExpr">Microsoft.FSharp.Compiler.Ast.SynExpr option</param>
  /// <param name="range">Microsoft.FSharp.Compiler.Range.range</param>
  /// <returns>Constructed instance.</returns>
  let genSynValSig_ValSpfn(synAttributes, ident, explicitValDecls, synType, arity, isInline, isMutable, xmlDoc, accessibility, synExpr, range) =
    Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
      (synAttributes,
       ident,
       explicitValDecls,
       synType,
       arity,
       isInline,
       isMutable,
       xmlDoc,
       accessibility,
       synExpr,
       range)

  ////////////////////////////////////////////////////

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValTyparDecls".
  /// </summary>
  /// <param name="item1">Microsoft.FSharp.Compiler.Ast.SynTyparDecl list</param>
  /// <param name="item2">bool</param>
  /// <param name="constraints">Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list</param>
  /// <returns>Constructed instance.</returns>
  let genSynValTyparDecls(item1, item2, constraints) =
    Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
      (item1,
       item2,
       constraints)

