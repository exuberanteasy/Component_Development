Recursive  遞迴??

C# 這個語言


using System;

namespace m2_pp_43_base
{
    public class Parent
    {
        virtual public void vd(int k)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("蕭規曹隨");
            Console.ResetColor();
        }
    }
    public class Derived : Parent
    {
// fix  #1 觀察下一行 override
        override public void vd(int k)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("青出於藍");
            Console.ResetColor();
// fix  #4 看下一行 vd 改成 base.vd 執行會如何?
// fix  #3 將下一行註解取消, 看執行會如何?
            //vd(k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            Parent p = null;
            p = new Derived();
            // fix 練習 #2 看下一行 執行會如何?
            p.vd(888);
            Console.WriteLine("end");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

//==============================================================





