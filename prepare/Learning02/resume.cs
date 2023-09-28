using System;

public class resume
{
    public string _name;

    public List<job>_jobs = new List<job>();

    public void display()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (job job in _jobs)
        {
            job.display();
        }
    }
}