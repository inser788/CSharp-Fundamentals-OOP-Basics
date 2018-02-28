public class Tomcat:Cat
{
    public Tomcat(string name, int age)
        : base(name, age, "Male")
    {

    }

    public override string GetSound()
    {
        return "MEOW";
    }
}

