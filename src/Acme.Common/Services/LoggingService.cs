using Acme.Common.Services.Interfaces;

namespace Acme.Common.Services;
public static class LoggingService
{
    public static void WriteToFile(IEnumerable<ILoggable> itemsToLog)
    {
        foreach (var item in itemsToLog)
            Console.WriteLine(item.Log());
    }
}