using System.Data.Common;

public abstract class Employee{
    public string name{get;set;}
    public string id {get;set;}
    public double salary {get;set;}

    public virtual void  CalculateSalary(){
        // return salary;
    }

}