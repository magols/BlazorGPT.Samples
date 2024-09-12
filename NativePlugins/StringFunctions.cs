using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace BlazorGPT.Samples.Native;

public class StringFunctions
{

    [KernelFunction("count_chars")]
    [Description("Counts the number of characters in a string")]
    [return:Description("The length of the string")]
    public int CountChars([Description("the text to count characters on")]string input)
    {
        return input.Length;
    }

}