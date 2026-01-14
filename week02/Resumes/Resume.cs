using System;

public class Resume
{
    public string _name;

    // Initializing the list with a new List before use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // Calling the Display method on each job
            job.DisplayJobDetails();
        }
    }
}