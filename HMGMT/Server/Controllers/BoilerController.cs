using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace HMGMT.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class BoilerController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var client = new RestClient("http://10.0.0.224/api/boiler/info");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.Content;
    }

}