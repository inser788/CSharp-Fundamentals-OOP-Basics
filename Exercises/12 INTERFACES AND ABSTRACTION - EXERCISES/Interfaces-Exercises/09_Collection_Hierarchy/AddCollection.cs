using System.Collections.Generic;

public class AddCollection : IAddable
{
    private List<string> collection;

    public AddCollection()
    {
        this.collection = new List<string>();
    }

    public List<string> Collection
    {
        get { return this.collection; }
        //protected set { this.collection = value; }
    }

    public virtual int Add(string element)
    {
        this.collection.Add(element);
        return this.collection.Count - 1;
    }
}