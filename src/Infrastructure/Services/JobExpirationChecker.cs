using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Services;

public class JobExpirationChecker : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;


    public JobExpirationChecker(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // Calcular el tiempo restante hasta la próxima medianoche (00:00 hs)
            var now = DateTime.Now;
            var nextMidnight = now.Date.AddDays(1);
            var delay = nextMidnight - now;

            // Esperar hasta la medianoche
            await Task.Delay(delay, stoppingToken);

            // Crear un scope para obtener el servicio
            using (var scope = _scopeFactory.CreateScope())
            {
                var jobService = scope.ServiceProvider.GetRequiredService<IJobExpirationService>();
                await jobService.CheckAndExpireJobsAsync(stoppingToken);
            }
        }
    }

    //    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    //    {
    //        while (!stoppingToken.IsCancellationRequested)
    //        {
    //            using (var scope = _scopeFactory.CreateScope())
    //            {
    //                var jobService = scope.ServiceProvider.GetRequiredService<IJobExpirationService>();
    //                await jobService.CheckAndExpireJobsAsync(stoppingToken);
    //            }

    //            // Esperar 1 hora (ajustable)
    //            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
    //        }
    //    }
    //}

}