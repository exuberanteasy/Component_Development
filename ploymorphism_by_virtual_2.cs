m2_pp_40_ploymorphism_by_virtual


using System;
using Microsoft.VisualBasic;

namespace m2_pp_40_ploymorphism_by_virtual
{
    public class 員工
    {  
        // fix #1 觀察下一行, 使用 virtual 
        // 來修飾 此 public void CalculatePay() 方法
        // 是代表 繼承 "class 員工" 類別的子孫類別
        //  可以 override 這個方法
        virtual public void CalculatePay(int hm)
        {
            Interaction.MsgBox   ("員工 CalculatePay(int ) 方法");
        }   
    }
    public class 月薪員工 : 員工
    {
        // fix #5 將下四行註解取消, 再 觀察 練習 #4下一行執行的情形
        //   稱呼為 shadow 遮蔽
        //public void CalculatePay(double t)
        //{
        //    Interaction.MsgBox("月薪員工  public void CalculatePay(double t) 方法");
        //}
        public double MonthlyPay = 22000;
        
        // fix #2 觀察下一行, 使用 override 
        // 來修飾 此 public void CalculatePay() 方法
        // 是代表 繼承 "class 員工" 類別的子孫類別
        //  在override 這個方法
        override public void CalculatePay(int hm )
        {
            Interaction.MsgBox("發月薪" + hm + " 元");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // fix 練習 #3 觀察下一行變數 x 的型態
            月薪員工 x = new 月薪員工(); 
            
            // fix 練習 #4 觀察下一行執行的情形
            x.CalculatePay(3950); 
        }
    }
}
