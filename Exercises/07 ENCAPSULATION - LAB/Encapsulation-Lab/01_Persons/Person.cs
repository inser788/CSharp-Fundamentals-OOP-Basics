﻿public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} is {this.age} years old.";
    }
}

