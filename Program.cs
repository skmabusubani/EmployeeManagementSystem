using System;
using System.Security.Cryptography.X509Certificates;
public delegate void EmployeeDelegate();
public class Program{
    public static void Main(){
        Manager man=new Manager{name ="Ram",id="Id01",salary=30000};
        
        MarketingExecutive mx=new MarketingExecutive{name="Syam",id ="Id02",salary=40000,km=100};

        EmployeeDelegate emp=new EmployeeDelegate(man.CalculateSalary);
        
        
        emp+=mx.CalculateSalary;
           
        emp();
        Console.WriteLine("jsdfsn");
    }

}