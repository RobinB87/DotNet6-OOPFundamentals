namespace ACM.BL;
public class Customer
{
    public int Id { get; private set; }
    public string EmailAddress { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
	public string FullName
	{
        get => $"{LastName},{FirstName}"; 
	}
}