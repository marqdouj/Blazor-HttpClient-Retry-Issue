using AspireRetryApp.ApiClient;

namespace AspireRetryApp.WebApp
{
    public interface IApiServiceClient
    {
        IDevelopmentClient Development { get; }
    }

    public class ApiServiceClient(HttpClient httpClient) : IApiServiceClient
    {
        public IDevelopmentClient Development { get; } = new DevelopmentClient(httpClient);
    }
}
