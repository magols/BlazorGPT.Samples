Checkout this repo in a sibling folder to the BlazorGPT repository.  

The folder structure should look like this:
```
- BlazorGPT
- BlazorGPT.Samples
```

Compile the samples project first. It will copy the semantic plugins from Plugins folder to the BlazorGPT.Web project. It will also copy the DLL file to the BlazorGPT project.

Then compile and run the BlazorGPT.Web project. 

The samples plugins should now be available för selection in the Plugins list.

Please note that this should be used CAREFULLY in production, lol.

#### Plugin requirements
To create a (native = code) plugin with functions that will be detected and available in BlazorGPT, you need to follow these requirements:
- decorate the action methods in the class with the [KernelFunction] attribute and relevant Descriptions
- the class must be public and have a public constructor that takes an IServiceProvider as a parameter

#### Plugin example
```csharp

public class StringFunctions(IServiceProvider serviceProvider)
{

    [KernelFunction("count_chars")]
    [Description("Counts the number of characters in a string")]
    [return:Description("The length of the string")]
    public int CountChars([Description("the text to count characters on")]string input)
    {
        return input.Length;
    }
}

```