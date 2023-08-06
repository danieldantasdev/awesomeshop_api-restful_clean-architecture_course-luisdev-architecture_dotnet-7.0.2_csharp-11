namespace AwesomeShop.Core.ValueObjects;

public record CustomerAddress(string Street, string Number, string ZipCode, string City, string State, string Country)
{
    public string GetFullAddress()
    {
        return $"{Street}, {Number}, {ZipCode}, {City}, {State}, {Country}";
    }
}