 public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName => firstName;

    public string LastName => lastName;

    public int Age => age;

    public decimal Salary => salary;

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age < 30)
        {
            this.salary += salary * percentage / 200m;
        }
        else
        {
            this.salary += salary * percentage / 100m;
        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
}

