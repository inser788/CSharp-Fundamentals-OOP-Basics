 using System;
 using System.Text;

public class Animal
 {
     private string name;
     private int age;
     private string gender;

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    
    public string Name
     {
         get => name;
         set
         {
             if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
             {
                 throw new ArgumentException("Invalid input!");
             }

             this.name = value;
         }
     }

     public int Age
     {
         get => age;
         set
         {
             if (value<0)
             {
                 throw new ArgumentException("Invalid input!");
            }

             this.age = value;
         }
     }

     public string Gender
     {
         get => gender;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

     public virtual string GetSound()
     {
         return String.Empty;
     }

     public override string ToString()
     {
        StringBuilder builder=new StringBuilder();
         builder.AppendLine($"{this.GetType().Name}")
             .AppendLine($"{this.Name} {this.Age} {this.Gender}")
             .AppendLine($"{this.GetSound()}");
         return builder.ToString().TrimEnd();
     }
 }

