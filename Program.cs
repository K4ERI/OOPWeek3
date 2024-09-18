// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[]args)
    {
        //creating an object (variable of certain class type)
        Trransaction trransaction = new Trransaction();

        trransaction.setDate(new DateTime(2008, 6, 1));
        trransaction.setVal(10.5f);

        Console.WriteLine("transaction value is " + trransaction.getVal() + " at time " + trransaction.getDate().ToString());
    }
}
