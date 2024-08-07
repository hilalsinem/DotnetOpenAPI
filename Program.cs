
using dotnetApiProject.Services;
using Microsoft.Extensions.DependencyInjection;
using OpenAI;
using OpenAI.Extensions;
using OpenAI.Interfaces;
using OpenAI.Managers;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<OpenAICompletionService>();
builder.Services.AddOpenAIService();
builder.Services.AddOpenAIService(settings => settings.ApiKey = "sk-_oOF1M-2tJ69jZ1SuUJELtNEGxphFgOEq-9qiimHaHT3BlbkFJ4XeG6WOZxXbO0ymmD43x6NQ-jK1nG7MpbHcay_Ku0A");

var host = builder.Build();
host.Run();
