using System;
using System.Collections.Generic;

namespace Resume{
class Program
{
    static void Main(string[] args)
    {
        List<Job> jobs = new List<Job>();
        jobs.Add(new Job("Microsoft", "Softwere Engineer", 2018, 2020)); 
        jobs.Add(new Job("Dell", "Softwere Engineer", 2020, 2022));
        jobs.Add(new Job("Google", "Softwere Engineer", 2022));
        Resume theResume = new Resume("John Doe", jobs);
        theResume.Display();
        //Console.WriteLine("Hello Learning02 World!");
    }
}
class Job{
    private string companyName, jobTitle;
    private int startYear, endYear;
    
    //Constructors
    public Job(){
        this.companyName = "Not a Name";
        this.jobTitle = null;
        this.startYear = 2023;
        this.endYear = 2023;
    }
    public Job(string company){
        this.companyName = company;
        this.jobTitle = null;
        this.startYear = 2023;
        this.endYear = 2023;
    }
    public Job(string company, int startYear){
        this.companyName = company;
        this.jobTitle = null;
        this.startYear = startYear;
        this.endYear = 2023;
    }
    public Job(string company, int startYear, int endYear){
        this.companyName = company;
        this.jobTitle = null;
        this.startYear = startYear;
        this.endYear = endYear;
    }
    public Job(string company, string title){
        this.companyName = company;
        this.jobTitle = title;
        this.startYear = 2023;
        this.endYear = 2023;
    }
    public Job(string company, string title, int startYear){
        this.companyName = company;
        this.jobTitle = title;
        this.startYear = startYear;
        this.endYear = 2023;
    }
    public Job(string company, string title, int startYear, int endYear){
        this.companyName = company;
        this.jobTitle = title;
        this.startYear = startYear;
        this.endYear = endYear;
    }

    public string GetCompanyName(){
        return this.companyName;
    }
    public string GetJobTitle(){
        return this.jobTitle;
    }
    public int GetStartYear(){
        return this.startYear;
    }
    public int GetEndYear(){
        return this.endYear;
    }

    public void SetCompanyName(string Name){
        this.companyName = Name;
    }
    public void SetJobTitle(string title){
        this.jobTitle = title;
    }
    public void SetStartYear(int year){
        this.startYear = year;
    }
    public void SetEndYear(int year){
        this.endYear = year;
    }
    public void Display(){
        Console.Out.WriteLine(
            $"{this.jobTitle} ({this.companyName}) {this.startYear}-{this.endYear}"
        );
    }
}
class Resume{
    private string name;
    private List<Job> jobs;

    public Resume(){
        this.name = null;
        jobs = new List<Job>();
    }
    public Resume(string name){
        this.name = name;
        jobs = new List<Job>();
    }
    public Resume(string name, List<Job> jobs){
        this.name = name;
        this.jobs = jobs;
    }

    public void AddJobs(List<Job> newJobs){
        foreach(Job newJob in newJobs){
            this.AddJob(newJob);
        }
    }
    public void AddJob(Job newJob){
        this.jobs.Add(newJob);
    }
    public List<Job> ClearJobs(){
        List<Job> oldJobs = this.jobs;
        this.jobs.Clear();
        return oldJobs;
    }

    public Job GetJobAtIndex(int index){
        Job wantedJob;
        wantedJob = this.jobs[index];
        return wantedJob;
    }
    public List<Job> GetJobs(){
        return this.jobs;
    }
    public string GetName(){
        return this.name;
    }

    public void Display(){
        Console.Out.WriteLine($"Name: {this.name}");
        Console.Out.WriteLine("Jobs: ");
        foreach(Job job in jobs){
            job.Display();
        }
    }
}

}