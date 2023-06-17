using RestSharp;

namespace API_Services.QaseApi;

public abstract class BaseService
{
    protected readonly RestClient RClient;
    protected const string BaseUrl = "https://api.qase.io/v1";
    private const string Token = "81702e1f8e1f60430459a6a61790c8b293ed643f98e19195749aa14c884e1d70";

    protected BaseService()
    {
        RClient = new RestClient();
        RClient.AddDefaultHeader("token", Token);
    }
}