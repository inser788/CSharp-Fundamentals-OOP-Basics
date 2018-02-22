using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public List<Person> FirstTeam => firstTeam;

    public List<Person> ReserveTeam => reserveTeam;

    public void AddPlayer(Person person)
    {
        if (person.Age<40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }

    public override string ToString()
    {
        return $"First team has {firstTeam.Count} players.\n" +
               $"Reserve team has {reserveTeam.Count} players.";
    }
}

