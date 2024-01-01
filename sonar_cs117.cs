//(cwe400), (cwe1333)
public void RegexPattern(string input)
{
    var emailPattern = new Regex(".+@.+", RegexOptions.None);
    var isNumber = Regex.IsMatch(input, "[0-9]+");
    var isLetterA = Regex.IsMatch(input, "(a+)+");
}