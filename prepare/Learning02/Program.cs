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
    private protected int currentYear = 2023; // this is th current year Change every year
    //Constructors
    public Job(){
        this.companyName = "Not a Name";
        this.jobTitle = null;
        this.startYear = this.currentYear;
        this.endYear = this.currentYear;
    }
    public Job(string company){
        this.companyName = company;
        this.jobTitle = null;
        this.startYear = this.currentYear;
        this.endYear = this.currentYear;
    }
    public Job(string company, int startYear){
        this.companyName = company;
        this.jobTitle = null;
        this.startYear = startYear;
        this.endYear = this.currentYear;
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
        this.startYear = this.currentYear;
        this.endYear = this.currentYear;
    }
    public Job(string company, string title, int startYear){
        this.companyName = company;
        this.jobTitle = title;
        this.startYear = startYear;
        this.endYear = this.currentYear;
    }
    public Job(string company, string title, int startYear, int endYear){
        this.companyName = company;
        this.jobTitle = title;
        this.startYear = startYear;
        this.endYear = endYear;
    }

    public string GetCompanyName(){
        /*
        @pram: None
        @return: string, the String of the comony name
        */
        return this.companyName;
    }
    public string GetJobTitle(){
        /*
        @pram: None
        @return: string, The Job Title
        */
        return this.jobTitle;
    }
    public int GetStartYear(){
        /*
        @pram: None
        @return: int, The Start Year value
        */
        return this.startYear;
    }
    public int GetEndYear(){
        /*
        @pram: None
        @retrurn: int, The End Year value
        */
        return this.endYear;
    }

    public void SetCompanyName(string Name){
        /*
        @Pram: String, What is wanted to set the Compony name to
        @retrun: None
        */
        this.companyName = Name;
    }
    public void SetJobTitle(string title){
        /*
        @Pram: String, What the Job title is wanted to be set to
        @return: None
        */
        this.jobTitle = title;
    }
    public void SetStartYear(int year){
        /*
        @pram: int, What the Start Year is being set to
        @return: None
        */
        this.startYear = year;
    }
    public void SetEndYear(int year){
        /*
        @pram: int, What the End Year is being set to
        @retrun: None
        */
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
        /*
        @pram: List<Job>, A list made up of Job class
        @return: None
        */
        foreach(Job newJob in newJobs){
            this.AddJob(newJob);
        }
    }
    public void AddJob(Job newJob){
        /*
        @pram: job, What Job is being added to the Resume
        @retrun: None
        */
        this.jobs.Add(newJob);
    }
    public List<Job> ClearJobs(){
        /*
        @pram: None
        @retrun: List<Job>, the cleared List<Job>
        */
        List<Job> oldJobs = this.jobs;
        this.jobs.Clear();
        return oldJobs;
    }

    public Job GetJobAtIndex(int index){
        /*
        @pram: int, the lookup index
        @retrun: Job, the Job in List<Job> at the index 
        */
        Job wantedJob;
        wantedJob = this.jobs[index];
        return wantedJob;
    }
    public List<Job> GetJobs(){
        /*
        @pram: None
        @return: List<job>, retruns the List<Job>
        */
        return this.jobs;
    }  
    public string GetName(){
        /*
        @pram: None
        @retrun: string, The name varable
        */
        return this.name;
    }

    public void Display(){
        Console.Out.WriteLine($"Name: {this.name}");
        Console.Out.WriteLine("Jobs: ");
        foreach(Job job in jobs){
            Console.Out.Write("    "); // 4 spaces
            job.Display();
        }
    }
}

}