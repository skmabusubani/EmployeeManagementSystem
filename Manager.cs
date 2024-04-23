public class Manager:Employee{
    private double PetAll = 0.08;
    private double FooAll=0.13;
    private double OthAll=0.03;

    public override void CalculateSalary(){
        double gs=salary+(salary*PetAll)+(salary*FooAll)+(salary*OthAll);
        double ns=gs-(salary*0.12);
        Console.WriteLine("Manager: "+id+" "+name+" net salary is "+ns);
        // return ns;
        

    }
}