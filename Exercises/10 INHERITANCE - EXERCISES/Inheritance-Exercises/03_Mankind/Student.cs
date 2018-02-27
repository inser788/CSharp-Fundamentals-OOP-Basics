using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private const int minLength = 5;
    private const int maxLength = 10;

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get => facultyNumber;
        protected set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)||value.Any(v=>!char.IsLetterOrDigit(v)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
        return builder.ToString().TrimEnd();
    }
}

