//(cwe117), (cwe532)
namespace Logging
{
    class SerilogLogging
    {
        void Foo() {
            new Serilog.LoggerConfiguration(); // Sensitive
        }
    }
}