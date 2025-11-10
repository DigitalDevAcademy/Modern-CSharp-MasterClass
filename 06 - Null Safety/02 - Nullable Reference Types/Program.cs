Address someAddress = new("123 Main St", "SomeCity", "SomeState", "12345", "US");

Person person1 = new("John", "Doe", someAddress);
Person person2 = new("Mark", "Doe");

PersonCityFinder(person1);
PersonCityFinder(person2);

void PersonCityFinder(Person person)
{
    if (person.CurrentAddress is Address a)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} is currently in {a.City} city.");
    }
    else
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} does not have a current address, so cannot show the city.");
    }
}

class Person
{
    public Person(string firstName, string lastName) : this(firstName, lastName, null)
    {
    }

    public Person(string firstName, string lastName, Address? address)
    {
        FirstName = firstName;
        LastName = lastName;
        CurrentAddress = address;
    }

    public string FirstName { get; init; }

    public string LastName { get; init; }
    
    public Address? CurrentAddress { get; set; }
}

class Address(string addressLine, string city, string state, string postalCode, string country)
{
    public string AddressLine { get; init; } = addressLine;
    public string City { get; init; } = city;
    public string State { get; init; } = state;
    public string PostalCode { get; init; } = postalCode;
    public string Country { get; init; } = country;
}