namespace Learning02;
class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display(){
        Console.WriteLine($"{_company} {_jobTitle}");
    }
}