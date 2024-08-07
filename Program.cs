
using dotnetApiProject.Services;
using Microsoft.Extensions.DependencyInjection;
using OpenAI;
using OpenAI.Extensions;
using OpenAI.Interfaces;
using OpenAI.Managers;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<OpenAICompletionService>();
builder.Services.AddOpenAIService();
builder.Services.AddOpenAIService(settings => settings.ApiKey = "sk-_oOF1M-2tJ69jZ1SuUJELtNEGxphFgOEq-");

var host = builder.Build();
host.Run();
