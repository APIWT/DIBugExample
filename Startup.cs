[assembly: Microsoft.Azure.Functions.Extensions.DependencyInjection.FunctionsStartup(typeof(DIBugExample.Startup))]

namespace DIBugExample
{
    using System;
    using Microsoft.Azure.Functions.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            Console.WriteLine("Startup has been called!");
            builder.Services.AddScoped<IGreeter, SampleGreeter>();
        }
    }
}
