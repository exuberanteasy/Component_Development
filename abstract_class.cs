// m2_pp_38_abstract_class

namespace m2_pp_38_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // fix #1 寫程式 用用看下面兩個類別
            CatLike ck;
            ck = new Lion();

        }
    }

    public abstract class CatLike // CatLike 為抽象類別
    {
      
    }
    public class Lion : CatLike
    {
       
    }
}


//================================================================
1.virtual(虛擬)
