public class MarketingExecutive:Employee{
    private int Tellphone = 1000;
    private int travel=5;
    public double km{get;set;}

    public override void CalculateSalary(){
        double TravAll=km*travel;
        double gs=salary+TravAll+Tellphone;
        double ns=gs-(salary*0.12);
        Console.WriteLine("MarketingExcutive: "+id+" "+name+" net salary is "+ns);
        // return ns;


    } 
}