using System;
using System.Threading;

class MarvelDC
{
    static void Main(string[] args)
    {

        Thread ironMan = new Thread(IronManTask);
        Thread batman = new Thread(BatmanTask);

        ironMan.Start();
        batman.Start();

        ironMan.Join();
        batman.Join();

        Console.WriteLine("All tasks are complete.");
    }

    static void IronManTask()
    {
        Console.WriteLine("Iron Man is upgrading his suit...");
        Thread.Sleep(100);
        Console.WriteLine("Iron Man has finished his task.");
    }

    static void BatmanTask()
    {
        Console.WriteLine("Batman is patrolling Gotham...");
        Thread.Sleep(100); 
        Console.WriteLine("Batman has finished his task.");
    }
}
