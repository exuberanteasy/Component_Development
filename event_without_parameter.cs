m2_pp_55_event_without_parameter

using System;


namespace m2_pp_55_event_without_parameter
{
    // fix 練習 #1 發明一個委派型態, 稱呼為 TheUsedChanged
    // 此 委派 沒有傳回值 , 也 沒有參數


    public delegate void TheUsedChanged();


    public class Book
    {
        // fix 練習 #2 發明一個 事件, 稱呼為 theUsedChanged
        // 此事件的型態為 TheUsedChanged
        // 此事件 為 public 等級

        public event TheUsedChanged theUsedChanged = /*null*/ ;


        public void TheFlip()
        {
            //fix 練習 #3 在下面寫程式 去 引發 theUsedChanged 事件

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // fix 練習 #4 寫程式去用這個 Book 物件的 theUsedChanged 事件
            //   比如: 訂閱  theUsedChanged 事件
            //  


        }
    }
}
