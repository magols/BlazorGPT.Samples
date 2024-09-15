using BlazorGPT.Data.Model;
using BlazorGPT.Pipeline.Interceptors;
using Microsoft.SemanticKernel;

namespace BlazorGPT.Samples.Interceptors;

public class SampleContextInterceptor(IServiceProvider serviceProvider) : InterceptorBase(serviceProvider), IInterceptor
{
    public override string Name { get; } = "Sample Context interceptor";

    public override Task<Conversation> Send(Kernel kernel, Conversation conversation,
        Func<string, Task<string>>? onComplete = null,
        CancellationToken cancellationToken = default)
    {
        if (conversation.Messages.Count == 1)
        {
            conversation.Messages.First().Content = "This is some added context." + conversation.Messages.First().Content;
        }

        return Task.FromResult(conversation);
    }

    public override Task<Conversation> Receive(Kernel kernel, Conversation conversation,
        Func<string, Task<string>>? onComplete = null,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(conversation);
    }
}