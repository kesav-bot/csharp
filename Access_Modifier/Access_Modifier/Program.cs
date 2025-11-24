using System;

class BaseClass
{
    public string PublicVar = "Public Member";

    private string PrivateVar = "Private Member";

    protected string ProtectedVar = "Protected Member";

    internal string InternalVar = "Internal Member";

    protected internal string ProtectedInternalVar = "Protected Internal Member";

    private protected string PrivateProtectedVar = "Private Protected Member";

    public void ShowBaseMembers()
    {
        Console.WriteLine(" Inside BaseClass");
        Console.WriteLine(PublicVar);
        Console.WriteLine(PrivateVar);
        Console.WriteLine(ProtectedVar);
        Console.WriteLine(InternalVar);
        Console.WriteLine(ProtectedInternalVar);
        Console.WriteLine(PrivateProtectedVar);
    }
}

class DerivedClass : BaseClass
{
    public void ShowDerivedMembers()
    {
        Console.WriteLine("\nInside DerivedClass");

        Console.WriteLine(PublicVar);              
        // Console.WriteLine(PrivateVar);          // not possible
        Console.WriteLine(ProtectedVar);        
        Console.WriteLine(InternalVar);             
        Console.WriteLine(ProtectedInternalVar);    
        Console.WriteLine(PrivateProtectedVar);    
    }
}

class Program
{
    static void Main()
    {
        BaseClass b = new BaseClass();
        DerivedClass d = new DerivedClass();

        b.ShowBaseMembers();
        d.ShowDerivedMembers();

        Console.WriteLine("\nAccessing from Main()");

        Console.WriteLine(b.PublicVar);           
        // Console.WriteLine(b.PrivateVar);         // not possible
        // Console.WriteLine(b.ProtectedVar);       // not possible
        Console.WriteLine(b.InternalVar);
        Console.WriteLine(b.ProtectedInternalVar);  
        // Console.WriteLine(b.PrivateProtectedVar); // not possible

        Console.WriteLine("\nProgram Ended.");
    }
}
