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
            using (var scope = _scopeFactory.CreateScope())
            {
                var jobService = scope.ServiceProvider.GetRequiredService<IJobExpirationService>();
                await jobService.CheckAndExpireJobsAsync(stoppingToken);
            }

            // Esperar 1 hora (ajustable)
            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }
}