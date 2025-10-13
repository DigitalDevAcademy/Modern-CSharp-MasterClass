Employee employee = new("John", "Doe", "Marketing");
Console.WriteLine(employee.Badge);
Console.WriteLine(employee.Departement);
employee.Departement = "Sales";
Console.WriteLine(employee.Departement);

class Employee
{
    private string _firstName;

    private string _lastName;

    private string _departement;

    public Employee(string firstName, string lastName, string departement)
    {
        _firstName = firstName;
        _lastName = lastName;
        _departement = departement;
    }

    public string Badge
    {
        get { return $"{_firstName} {_lastName} {_departement}"; }
    }

    public string Departement
    {
        get { return _departement; }
        set { _departement = string.IsNullOrWhiteSpace(value) ? _departement : value; }
    }

    // public string Departement
    // {
    //     get { return field; }
    //     set { field = string.IsNullOrWhiteSpace(value) ? field : value; }
    // }
}