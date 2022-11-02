using Microsoft.AspNetCore.Mvc;
using RestSharp;
using HMGMT.Shared;
namespace HMGMT.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoilerController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var client = new RestClient($"{UrlConstants.emsUrl}/api/boiler/info");
        client.Timeout = 5000;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.Content;
    }
    
    [HttpPost("{value}")]
    public void Post(string value)
    {
        var client = new RestClient($"{UrlConstants.emsUrl}/api/boiler/wwseltemp/");
        client.Timeout = 5000;
        var request = new RestRequest(Method.POST);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", $"Bearer {UrlConstants.bearerToken}");
        var body = @"{" + "\n" +@$"    ""value"": {value}" + "\n" +@"}";
        request.AddParameter("application/json", body,  ParameterType.RequestBody);
        IRestResponse response = client.Execute(request);
    }

}