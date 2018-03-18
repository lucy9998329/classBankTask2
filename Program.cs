using System;

namespace classBankTask2
{
class Client 
{
    string Username {get; set;}

    string PinNumber {get; set;}

    double Balance {get; set;}
}

class Bank
{
    void WithDrawal(){
        Console.WriteLine("Logic for a withdrawal");
    }

}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Customer!");

            var c1 = new Client();
            var b1 = new Bank();
        }
    }
}
