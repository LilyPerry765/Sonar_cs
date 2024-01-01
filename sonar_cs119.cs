//(cwe88)
using System.Diagnostics;
Process p = new Process();
p.StartInfo.FileName = "/usr/bin/find";
p.StartInfo.ArgumentList.Add(input); // Sensitive