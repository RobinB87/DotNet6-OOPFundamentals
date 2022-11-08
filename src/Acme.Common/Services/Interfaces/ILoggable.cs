namespace Acme.Common.Services.Interfaces;
/// <summary>
/// Interface based Polymorphism: provide various implementations of the Log method via the ILoggable interface
/// </summary>
public interface ILoggable
{
    string Log();
}