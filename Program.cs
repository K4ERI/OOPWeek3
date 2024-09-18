// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[]args)
    {
        //creating an object (variable of certain class type)
        Trransaction trransaction = new Trransaction();

        trransaction.month = 1;
        trransaction.val = 10.5f;

        Console.WriteLine("transaction value is " + trransaction.val);
    }
}
