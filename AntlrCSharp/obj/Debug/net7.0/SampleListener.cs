﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\zhout\Downloads\myprolang-master\myprolang-master\AntlrCSharp\Content\Sample.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrCSharp.Content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SampleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISampleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] SampleParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] SampleParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] SampleParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] SampleParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] SampleParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] SampleParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] SampleParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] SampleParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] SampleParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] SampleParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] SampleParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] SampleParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] SampleParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] SampleParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] SampleParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] SampleParser.ComparisonExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] SampleParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] SampleParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] SampleParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] SampleParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] SampleParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] SampleParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] SampleParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] SampleParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] SampleParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] SampleParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] SampleParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] SampleParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] SampleParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] SampleParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] SampleParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] SampleParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] SampleParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] SampleParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] SampleParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] SampleParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.multOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOP([NotNull] SampleParser.MultOPContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.multOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOP([NotNull] SampleParser.MultOPContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.addOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOP([NotNull] SampleParser.AddOPContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.addOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOP([NotNull] SampleParser.AddOPContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.compareOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOP([NotNull] SampleParser.CompareOPContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.compareOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOP([NotNull] SampleParser.CompareOPContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.boolOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOP([NotNull] SampleParser.BoolOPContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.boolOP"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOP([NotNull] SampleParser.BoolOPContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] SampleParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] SampleParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SampleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SampleParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SampleParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SampleParser.BlockContext context);
}
} // namespace AntlrCSharp.Content
