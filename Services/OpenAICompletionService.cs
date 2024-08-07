using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using OpenAI.Interfaces;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels.ResponseModels;
using OpenAI.ObjectModels;

namespace dotnetApiProject.Services
{
    public class OpenAICompletionService : BackgroundService
    {
        readonly IOpenAIService _openAIService;

        public OpenAICompletionService(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    Console.Write("::Merhaba! Ne sormak istersiniz?");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Prompt boş olamaz. Lütfen tekrar deneyin");
                        continue;
                    }

                    CompletionCreateResponse result = await _openAIService.Completions.CreateCompletion(new CompletionCreateRequest()
                    {
                        Prompt = input,
                        MaxTokens = 500
                    }, Models.TextDavinciV3);

                    if (result?.Choices != null && result.Choices.Count > 0)
                    {
                        Console.WriteLine(result.Choices[0].Text);
                    }
                    else
                    {
                        Console.WriteLine("API cevap vermiyor.");
                        Console.WriteLine("Cevap: " + (result == null ? "null" : result.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
