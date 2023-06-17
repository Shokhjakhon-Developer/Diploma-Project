using NLog;
using NLog.Config;
using NLog.Targets;

namespace Utilities.Utilities;

public sealed class LLogger
{
    private static readonly Lazy<LLogger> LazyInstance = new(() => new LLogger());

    private readonly ILogger _log = LogManager.GetLogger(Environment.CurrentManagedThreadId.ToString());

    private LLogger()
    {
        try
        {
            LogManager.LoadConfiguration("NLog.config");
        }
        catch (FileNotFoundException)
        {
            LogManager.Configuration = GetConfiguration();
        }
    }

    private LoggingConfiguration GetConfiguration()
    {
        string str = "${date:format=yyyy-MM-dd HH\\:mm\\:ss} ${level:uppercase=true} - ${message}";
        LoggingConfiguration configuration = new LoggingConfiguration();

        // for console
        LogLevel info = LogLevel.Info;
        LogLevel fatal1 = LogLevel.Fatal;
        ConsoleTarget consoleTarget = new ConsoleTarget("logconsole");
        consoleTarget.Layout = str;
        configuration.AddRule(info, fatal1, consoleTarget);

        // for file
        LogLevel debug = LogLevel.Debug;
        LogLevel fatal2 = LogLevel.Fatal;
        FileTarget fileTarget = new FileTarget("logfile");
        fileTarget.DeleteOldFileOnStartup = true;
        fileTarget.FileName = "../../../Log/log.log";
        fileTarget.Layout = str;
        configuration.AddRule(debug, fatal2, fileTarget);
        return configuration;
    }

    public static LLogger Instance => LazyInstance.Value;

    public void Debug(string message) => _log.Debug(message);

    public void Info(string message) => _log.Info(message);

    public void Warn(string message) => _log.Warn(message);

    public void Error(string message) => _log.Error(message);

    public void Fatal(string message) => _log.Fatal(message);
}