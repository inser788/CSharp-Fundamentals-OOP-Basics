public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }
    public string Department
    {
        get => this.department;
        set => this.department = value;
    }
    public decimal Salary
    {
        get => this.salary;
        set => this.salary = value;
    }
    public string Email
    {
        get => this.email;
        set => this.email = value;
    }
    public int Age
    {
        get => this.age;
        set => this.age = value;
    }

    public override string ToString()
    {
        return $"{this.name} {this.salary:f2} {this.email} {this.age}";
    }
}

