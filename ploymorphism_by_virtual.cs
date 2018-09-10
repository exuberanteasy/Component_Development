m2_pp_40_ploymorphism_by_virtual

using System;
using Microsoft.VisualBasic;
namespace m2_pp_40_ploymorphism_by_virtual
{
    public class 員工
    {  // fix  #6 若您想要 "練習 #5" 語法正確, 下一行要加一個什麼修飾詞?
        virtual public void Other() { Interaction.MsgBox("員工 Other 方法");
        }
        // fix #1 觀察下一行, 使用 virtual 
        // 來修飾 此 public void CalculatePay() 方法
        // 是代表 繼承 "class 員工" 類別的子孫類別
        //  可以 override 這個方法
        virtual public void CalculatePay()
        {
            Interaction.MsgBox   ("員工 CalculatePay() 方法");
        }   
    }
    public class 月薪員工 : 員工
    {
        // fix 練習 #5 將下四行註解取消, 觀察 會如何?
        override public void Other()
        {
            Interaction.MsgBox("薪員工 Other 方法");
        }
        public double MonthlyPay = 22000;
        // fix #4 將下四行註解取消, 再 觀察 練習 #2下一行執行的情形
        // fix #3 觀察下一行, 使用 override 
        // 來修飾 此 public void CalculatePay() 方法
        // 是代表 繼承 "class 員工" 類別的子孫類別
        //  在override 這個方法
        override public void CalculatePay()
        {
            Interaction.MsgBox("發月薪" + MonthlyPay + " 元");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            員工 x = new 月薪員工(); //子孫物件的參考可存到祖先型態的變數 x
            
            // fix 練習 #2 觀察下一行執行的情形
            x.CalculatePay(); 
        }
    }
}



//===========================================================================
  =>  m2_pp_40_ploymorphism_by_virtual
  *改用 virtual 抽象方法
  
  
  
  
  
  
  
  
  
