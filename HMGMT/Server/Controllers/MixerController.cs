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
        var client = new RestClient($"http://10.0.0.224/api/mixer/{mixerId}");
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
        return response.Content;
    }

}