//(cwe1240)
var hashProvider1 = new MD5CryptoServiceProvider(); // Sensitive
var hashProvider2 = (HashAlgorithm)CryptoConfig.CreateFromName("MD5"); // Sensitive
var hashProvider3 = new SHA1Managed(); // Sensitive
var hashProvider4 = HashAlgorithm.Create("SHA1"); // Sensitive