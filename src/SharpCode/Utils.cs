using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SharpCode
{
    internal class Utils
    {
        public static string FormatSourceCode(string sourceCode) =>
            SyntaxNodeExtensions
                .NormalizeWhitespace(CSharpSyntaxTree.ParseText(sourceCode).GetRoot())
                .ToFullString();
    }
}
