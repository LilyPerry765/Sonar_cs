//(cwe20), (cwe400), (cwe1333)
public class ExampleController : Controller
{
    public IActionResult Validate(string regex, string input)
    {
        bool match = Regex.IsMatch(input, regex);

        return Json(match);
    }
}