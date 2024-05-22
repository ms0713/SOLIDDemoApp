using SOLIDDemo.DIP;
using SOLIDDemo.OCP;
using SOLIDDemo.SRP;

internal class Program
{
    private unsafe static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //int i = 1324567890;
        //var ptr = new IntPtr(i);

        //int value = ptr.ToInt32();

        ////int value = *(int*)(src + 0);

        //Console.WriteLine(value);

        //for (int i = 1,n = 5, j = n - i; i <= n; i++,j--)
        //{
        //    Console.Write(string.Empty.PadRight(j,' '));
        //    Console.WriteLine(string.Empty.PadLeft(i, '*'));
        //}

        DIP.Run();

        Console.ReadLine();
    }
}