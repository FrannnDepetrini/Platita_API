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
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Calcular la próxima medianoche
                    var now = DateTime.Now;
                    var nextMidnight = now.Date.AddDays(1);
                    var delay = nextMidnight - now;

                    // Esperar hasta la medianoche
                    await Task.Delay(delay, stoppingToken);

                    using var scope = _scopeFactory.CreateScope();
                    var jobService = scope.ServiceProvider.GetRequiredService<IJobExpirationService>();

                    await jobService.CheckAndExpireJobsAsync(stoppingToken);
                }
                catch (TaskCanceledException)
                {
                    // Ignorar cancelación esperada
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[JobExpirationChecker] Error: {ex.Message}");
                    // Podés loguear más en profundidad si tenés logger
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[JobExpirationChecker Fatal] Error fuera del bucle: {ex.Message}");
        }
    }


}