using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace LoadTestingDemo1.Controllers;

[ApiController]
[Route("[Controller]")]
public class StringController : ControllerBase
{
    [HttpGet("reverse")]
    public string Reverse([FromQuery] string input)
    {
        var reverse = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse.Append(input[i]);
        }
        Thread.Sleep(500);
        return reverse.ToString();
    }
}