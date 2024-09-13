using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace BlazorGPT.Samples;

// note that all classes with plugin functions must be public and have a constructor that takes an IServiceProvider as a parameter
public class StringFunctions(IServiceProvider serviceProvider)
{

    [KernelFunction("count_chars")]
    [Description("Counts the number of characters in a string")]
    [return:Description("The length of the string")]
    public int CountChars([Description("the text to count characters on")]string input)
    {
        return input.Length;
    }

    [KernelFunction("reverse_string")]
    [Description("Reverses a string")]
    [return: Description("The reversed string")]
    public string ReverseString([Description("the text to reverse")] string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    [KernelFunction("concat_strings")]
    [Description("Concatenates two strings")]
    [return: Description("The concatenated string")]
    public string ConcatStrings([Description("the first string")] string input1, [Description("the second string")] string input2)
    {
        return input1 + input2;
    }

}