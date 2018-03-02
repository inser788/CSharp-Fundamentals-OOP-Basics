using System;

public class Mission:IMission
{
    private string codeName;
    private string state;

    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }

    public string CodeName
    {
        get => codeName;
        set => codeName = value;
    }

    public string State
    {
        get => state;
        set
        {
            if (value!="inProgress"&&value!= "Finished")
            {
                throw new ArgumentException("Invalid State!");
            }

            this.state = value;
        }
       
    }

    public void CompleteMission()
    {
        this.State = "Finished";
    }


    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}

