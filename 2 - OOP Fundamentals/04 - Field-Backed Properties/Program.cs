Employee employee = new("John", "Doe", "Marketing");
Console.WriteLine(employee.Badge);
Console.WriteLine(employee.Department);
employee.Department = "Sales";
Console.WriteLine(employee.Department);

class Employee
{
    private string _firstName;

    private string _lastName;

    private string _department;

    public Employee(string firstName, string lastName, string departement)
    {
        _firstName = firstName;
        _lastName = lastName;
        _department = departement;
    }

    public string Badge
    {
        get { return $"{_firstName} {_lastName} {_department}"; }
    }

    public string Department
    {
        get { return _department; }
        set { _department = string.IsNullOrWhiteSpace(value) ? _department : value; }
    }

    // public string Department
    // {
    //     get { return field; }
    //     set { field = string.IsNullOrWhiteSpace(value) ? field : value; }
    // }
}