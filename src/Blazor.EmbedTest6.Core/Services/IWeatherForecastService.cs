using System;
using System.Threading.Tasks;

namespace Blazor.EmbedTest6.Core.Services
{
    public interface IWeatherForecastService
    {

        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
