//(cwe117), (cwe532)
namespace Logging
{
    class NLogLogging
    {
        void Foo(NLog.Config.LoggingConfiguration config) {
            NLog.LogManager.Configuration = config; // Sensitive, this changes the logging configuration.
        }
    }
}