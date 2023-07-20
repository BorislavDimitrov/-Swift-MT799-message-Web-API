using Serilog;
using System.Diagnostics;

namespace SwiftMessagesProcessor.Web
{
    public static class HostCollectionExtensions
    {
        #region Methods
        public static IHostBuilder AddLogger(this IHostBuilder host, IConfiguration configuration)
        {
            Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));
            Serilog.Debugging.SelfLog.Enable(Console.Error);
            host.UseSerilog((context, services, _configuration) =>
            {
                _configuration
                               .ReadFrom.Configuration(configuration)
                               .Enrich.FromLogContext()
                               ;
            });
            return host;
        }
        #endregion
    }
}

