using ACM.BL.Entities.Base;
using Acme.Common.Services.Interfaces;

namespace ACM.BL.Entities;
public class Customer : EntityBase, ILoggable
{
    /// <summary>
    /// Constructor chaining: use it when a constructor needs to call another
    /// in this case the default constructor calls the parameterized constructor
    /// with a default value of 0
    /// </summary>
    public Customer() : this(0) { }
    public Customer(int id)
    {
        Id = id;
        AddressList = new List<Address>();
    }

    public int Id { get; private set; }
    public int Type { get; set; }
    public string EmailAddress { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName
    {
        get
        {
            var fullName = LastName;
            if (string.IsNullOrWhiteSpace(FirstName))
                return fullName;

            return string.IsNullOrWhiteSpace(fullName)
                ? FirstName
                : fullName += $", {FirstName}";
        }
    }

    /// <summary>
    /// Example of composition: objects from one class is constructed of
    /// objects from other class. Construction of the Customer object
    /// constructs a list of address objects
    /// </summary>
    public IEnumerable<Address> AddressList { get; set; }

    public string Log() =>
        $"{Id}: {FullName} Email: {EmailAddress} Status: {EntityState}";

    /// <summary>
    /// Static denotes the member belongs to the class itself,
    /// rather than to any specific instance
    /// </summary>
    public static int InstanceCount { get; set; }

    public override bool IsValid() =>
        !string.IsNullOrWhiteSpace(LastName) &&
        !string.IsNullOrWhiteSpace(EmailAddress);
}