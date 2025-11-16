Address someAddress = new("123 Main St", "SomeCity", "SomeState", "12345", "US");

Person person1 = new("John", "Doe", someAddress);
Person person2 = new("Mark", "Doe");

PersonCityFinder(person1);
PersonCityFinder(person2);

void PersonCityFinder(Person person)
{
    if (person.CurrentAddress is Address ca)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} is currently in {ca.City} city.");
    }
    else
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} does not have a current address, so cannot show the city.");
    }
}

class Person(string firstName, string lastName, Address? address = null)
{
    public string FirstName { get; init; } = firstName;

    public string LastName { get; init; } = lastName;
    
    public Address? CurrentAddress { get; init; } = address;
}

class Address(string addressLine, string city, string state, string postalCode, string country)
{
    public string AddressLine { get; init; } = addressLine;

    public string City { get; init; } = city;
    
    public string State { get; init; } = state;
    
    public string PostalCode { get; init; } = postalCode;
    
    public string Country { get; init; } = country;
}