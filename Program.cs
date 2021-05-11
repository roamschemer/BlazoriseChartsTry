using Blazorise;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazoriseChartsTry {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //Blazorise.Charts
            builder.Services.AddBlazorise(options => {
                options.ChangeTextOnKeyPress = true;
            }).AddEmptyProviders();

            await builder.Build().RunAsync();
        }
    }
}
