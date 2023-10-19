
public class House
{
    public string OwnerName { get; }
    public Address Address { get; }

    public House(string ownerName, Address address)
    {
        if (ownerName == null)
        {
            throw new ArgumentNullException(nameof(ownerName));
        }
        if (address == null)
        {
            throw new ArgumentNullException(nameof(address));
        }
        OwnerName = ownerName;
        Address = address;
    }
}
