// 建構子 Constructor


public MyPS()
{
    // aaa      
}

//========================================================
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("開始");
            MyPS p = null;
            // fix 練習 #1 觀察程式的執行
            p = new MyPS( "take it easy" );
            Console.WriteLine("以上");
            Console.WriteLine((p.the == null)? "p.the 被設成 null " : (p.the ));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

//========================================================
namespace m2_pp_24_constructor
{
    public class MyPS
    {
        // fix #2 在下面發明一個建構子, 能讓 "練習 #1" 
        //   的那一行語法正確
        //   在這個 建構子 的身體內 
        //   寫程式讓 這個建構子 的引數 的值 
        //   設到 物件資料 the
        public  MyPS(string fn )
        {
            the = fn;
        }
        public MyPS()
        {
            //Perform simple initialization
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("建構子");
            Console.ResetColor();
        }
        public string the;
    }
}
