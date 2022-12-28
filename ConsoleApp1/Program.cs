namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = MyService.add(args);
            Console.WriteLine("兩數相加為:"+result);
        }
    }
    public class MyService
    {
        public static int add(string[] args)
        {
            //宣告變數
            int x = 0;
            int y = 0;
            string? s = null;

            //檢查數量
            if (args.Length != 2)
            {
                Console.WriteLine("fault input");
                System.Environment.Exit(1);
            }

            bool isOK = true;
            isOK = isOK && int.TryParse(args[0], out x);
            isOK = isOK && int.TryParse(args[1], out y);
            if (isOK != true)
            {
                System.Environment.Exit(1);
            }
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);

            return x + y;
        }
    }
}

