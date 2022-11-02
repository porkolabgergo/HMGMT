using HMGMT.Shared;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace HMGMT.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MixerController : ControllerBase
{
    [HttpGet("{mixerId}")]
    public string Get(string mixerId)
    {
        var client = new RestClient($"{UrlConstants.emsUrl}/api/mixer/{mixerId}");
        client.Timeout = 5000;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.Content;
    }

    //SelTemp based on mixerId
    [HttpPost("{mixerId}/{value}")]
    public void Post(string mixerId, string value)
    {
        var client = new RestClient($"{UrlConstants.emsUrl}/api/thermostat/{mixerId}/seltemp");
        client.Timeout = 5000;
        var request = new RestRequest(Method.POST);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", $"Bearer {UrlConstants.bearerToken}");
        var body = @"{" + "\n" +@$"    ""value"": {value}" + "\n" +@"}";
        request.AddParameter("application/json", body,  ParameterType.RequestBody);
        IRestResponse response = client.Execute(request);
    }

}