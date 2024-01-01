//(cwe20), (cwe113)
string value = Request.QueryString["value"];
Response.AddHeader("X-Header", value); // Noncompliant