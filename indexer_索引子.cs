using System;
namespace MsitBookClassLibrary1
{
    public class Book
    {
        // fix #1 觀察下面 Book 建構子 程式碼的執行情形
        public Book(string [] contents)
        {
            pages = new string[contents.Length] ;
            for (int i = 0; i < contents.Length; i++)
            {
                pages[i] = contents[i];
            }
        }
        // fix #3 觀察下面一行程式碼的 Number
        //   為 唯讀的屬性
        //   可讓 書的頁數(就是下面程式碼中的 Number)
        //   背後真正存 書的頁數 於下面程式碼中的 pages 的 Length
        public int Number
        {
            get
            {
                return pages.Length;
            }
        }
        // fix #6 觀察下面一行程式碼的 public string this [ int wp ]
        //   為 唯讀的indexer
        //   可讓 書每頁的字查出來, 就是下面程式碼中的 pages[ wp - 1 ]
        //  wp 是 >= 1 的值 而且 wp 是 <= Number
        //   是可以接受的
        //   但把書的 把書的每頁的字 設值, 是無法接受的
        public string this [ int wp ]
        {
            get
            {
                string answer = null;
                if (wp >= 1  && wp  <= Number)
                {
                    answer = pages[ wp - 1 ];
                }
                return answer;
            }
        }

        private string [] pages = new string[] { "" };    // 物件資料成員
    }

}


//=================================================================
//這樣試試看
public string this [int wp]
{
    get
    {
        string answer = null;
        if(wp >= 1 && wp <= Number)  //加一個 if 保護一下
        {
            answer = pages[wp - 1];
        }  //加這行
        return answer;
    }
}



