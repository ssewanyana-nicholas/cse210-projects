using System;

public class job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}