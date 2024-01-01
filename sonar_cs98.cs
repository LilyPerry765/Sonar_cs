//(cwe200), (cwe319)
using var smtp = new SmtpClient("host", 25); // Noncompliant, EnableSsl is not set
using var telnet = new MyTelnet.Client("host", port); // Noncompliant, rule raises Security Hotspot on any member containing "Telnet"