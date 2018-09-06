//解構子  Destructor

class MyPS {
    ~MyPS() /* 解構子 */{
        // 釋放資源
    }
}


//======================================================================

using System;
using System.IO;

namespace m2_pp_27_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");

            using (MyPS mp = new MyPS()/* ; */ )
            {
                string gidStr = Guid.NewGuid().ToString();
                mp.WriteLine(gidStr);
                
                
            }// 離開using { }時會自動呼叫mp.Dispose()
            Console.WriteLine("about");
        }
    }
    class MyPS : IDisposable
    {
        public void Dispose()
        {
            //釋放物件控制的資源
            sw.Close();
        }
        public void WriteLine(string s)
        {
            sw.WriteLine(s);
        }
        public MyPS()
        {
            sw = new StreamWriter(@"msit999.txt");
        }
        StreamWriter sw;
    }
    
}

//=============================================================================

using System;
namespace m2_pp_25_destructor
{
    class MyPC
    {

        static void Main()
        {
            MyPC p = new MyPC();
            // p = null;
            Console.WriteLine("p = null;");
            GC.GetTotalMemory(true);
           
            Console.WriteLine("以上");
            Console.WriteLine();
            Console.WriteLine();
        }
        // fix #1 觀察下面為解構子
        ~MyPC()
        {
            Console.WriteLine("解構子");
        }
    }
}

