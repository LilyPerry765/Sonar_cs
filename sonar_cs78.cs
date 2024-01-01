//(cwe20), (cwe918)
using System.Web;
using System.Web.Mvc;

public class ExampleController: Controller
{
    [HttpGet]
    public IActionResult ImageFetch(string location)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(location);

        return Ok();
    }
}