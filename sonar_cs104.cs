//(cwe117), (cwe532)
using System;
using System.IO;
using System.Xml;
using log4net.Appender;
using log4net.Config;
using log4net.Repository;

namespace Logging
{
    class Log4netLogging
    {
        void Foo(ILoggerRepository repository, XmlElement element, FileInfo configFile, Uri configUri, Stream configStream,
        IAppender appender, params IAppender[] appenders) {
            log4net.Config.XmlConfigurator.Configure(repository); // Sensitive
            log4net.Config.XmlConfigurator.Configure(repository, element); // Sensitive
            log4net.Config.XmlConfigurator.Configure(repository, configFile); // Sensitive
            log4net.Config.XmlConfigurator.Configure(repository, configUri); // Sensitive
            log4net.Config.XmlConfigurator.Configure(repository, configStream); // Sensitive
            log4net.Config.XmlConfigurator.ConfigureAndWatch(repository, configFile); // Sensitive

            log4net.Config.DOMConfigurator.Configure(); // Sensitive
            log4net.Config.DOMConfigurator.Configure(repository); // Sensitive
            log4net.Config.DOMConfigurator.Configure(element); // Sensitive
            log4net.Config.DOMConfigurator.Configure(repository, element); // Sensitive
            log4net.Config.DOMConfigurator.Configure(configFile); // Sensitive
            log4net.Config.DOMConfigurator.Configure(repository, configFile); // Sensitive
            log4net.Config.DOMConfigurator.Configure(configStream); // Sensitive
            log4net.Config.DOMConfigurator.Configure(repository, configStream); // Sensitive
            log4net.Config.DOMConfigurator.ConfigureAndWatch(configFile); // Sensitive
            log4net.Config.DOMConfigurator.ConfigureAndWatch(repository, configFile); // Sensitive

            log4net.Config.BasicConfigurator.Configure(); // Sensitive
            log4net.Config.BasicConfigurator.Configure(appender); // Sensitive
            log4net.Config.BasicConfigurator.Configure(appenders); // Sensitive
            log4net.Config.BasicConfigurator.Configure(repository); // Sensitive
            log4net.Config.BasicConfigurator.Configure(repository, appender); // Sensitive
            log4net.Config.BasicConfigurator.Configure(repository, appenders); // Sensitive
        }
    }
}