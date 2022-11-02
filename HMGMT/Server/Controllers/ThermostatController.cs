using Microsoft.AspNetCore.Mvc;
using RestSharp;
using HMGMT.Shared;

namespace HMGMT.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThermostatController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var client = new RestClient($"{UrlConstants.emsUrl}/api/thermostat/info");
        client.Timeout = 5000;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.Content;
    }

}