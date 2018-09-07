using System;

namespace m2_pp_29_static_data_and_static_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // fix #3  再執行此程式, 看會如何? 
            // fix #1  執行此程式, 看會如何? 
            Console.Write("SavingsAccount.InterestRate 為 ");
            Console.WriteLine(SavingsAccount.InterestRate);
            Console.WriteLine();

            Console.WriteLine("SavingsAccount.InterestRate = 0.03;");
            SavingsAccount.InterestRate = 0.03;
            Console.WriteLine();

            Console.Write("SavingsAccount.InterestRate 為 ");
            Console.WriteLine(SavingsAccount.InterestRate);

            Console.WriteLine();
            Console.Write("SavingsAccount.FetchRate() 為 ");
            // fix #4  將下一行註解取消,  看會如何? 
            Console.WriteLine(SavingsAccount.FetchRate());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public class SavingsAccount
    {
        // fix #2  請發明一個 靜態 資料成員 
        //, 型態為 double , 名稱為 InterestRate
        //  初值設為 0.01 為 public 等級
        public static  double InterestRate = 0.01;

        // fix #5  請發明一個 靜態 方法 
        //, 傳回值型態為 double , 名稱為 FetchRate , 沒有引數
        //  為 public 等級
        // 在此方法的身體內 , 傳回 SavingsAccount.InterestRate 的值
        public static  double FetchRate( )
        {
            return SavingsAccount.InterestRate;
        }
        //略
        public double Balance;
    }
}


//========================================================
※物件方法裡可以直接呼叫物件方法，但靜態方法裡不能呼叫物件方法。




