C# EventHandler Example
// http://me1237guy.pixnet.net/blog/post/65728063-c%23-eventhandler-example

(1) 先自訂義事件資料類別 ThresholdReachedEventArgs, 其繼承EventArgs 該類別存在兩個公開方法,分別記錄門檻值和達門檻值時間

// (1) 自訂義事件資料(event data)
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
    
(2) event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

其中關鍵字 EventHandler是一種委派
public delegate void EventHandler(object sender, EventArgs e)
EventHandler 後面接<事件參數型態>, 在此為自定義事件資料 ThresholdReachedEventArgs(繼承自EventArgs)

(3) (Line25)protected virtual void OnThresholdReached(ThresholdReachedEventArgs e){…}

定義 虛擬函式做為該事件負責的方法(method)樣版, 可以之後覆寫之…。
(4) 實體化ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();

     傳入args.Threshold和TimeReached

     然後呼叫虛擬函式, 同時傳入該args至 OnThresholdReached(args)

最後來回頭看Counter這個類別就簡單多, 

1. (Line 3,4) 私有成員分別為threshold(門檻值)和total(累加量)

2. (Line 5) 有傳參數創建子Counter(int passThreshold)， 更新私有成員threshold(門檻值)

3. (Line 9) 公有方法Add(int x)，每次傳入一個數值進行累加至私有成員total

4. (Line 14) 一旦total超過門檻值，先實體化ThresholdReachEventArgs事件參數args，接著透過args兩個公開方法,分別記錄門檻值和達門檻值時間

5. (Line 21) 呼叫虛擬函式OnThresholdReached(args), 同時傳入該args至 OnThresholdReached(args)

1: class Counter
   2:   {
   3:       private int threshold;
   4:       private int total;
   5:       public Counter(int passedThreshold )
   6:       {
   7:           threshold = passedThreshold;
   8:       }
   9:       public void Add(int x)
  10:       {
  11:           total += x;
  12:           Console.WriteLine("The total is now equal to {0}", total);
  13:  
  14:           if (total>=threshold)
  15:           {
  16:               //(4) 實體化ThresholdReachedEventArgs, 接著傳入門檻值和達到門檻值時間
  17:               ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
  18:               args.Threshold = threshold;
  19:               args.TimeReached = DateTime.Now;
  20:               //(5) 呼叫虛擬函式
  21:               OnThresholdReached(args);
  22:           }
  23:       }
  24:       //(3) 定義事件處理method
  25:       protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
  26:       {
  27:           EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
  28:           if(handler !=null)
  29:           {
  30:               handler(this, e);
  31:           }
  32:       }
  33:       //(2) 定義事件成員
  34:       public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
  35:   }


1. (Line 3)先亂數產生0~9亂數值，儲存至threshold

2. (Line 6)產生Counter實體c

3. 接著去定義c的ThresholdReached事件處理函式(Line 7)，在此由自訂函式c_ThresholdReach負責覆寫當初虛擬函式OnThresholdReached

4. 先看覆寫函式c_ThreshReached做了甚麼事情? 第一個參數sender事件來源(誰發出的), 第二參數 事件參數(包含門檻值和達門檻時間)，在此僅印出(WriteLine)門檻值和達門檻時間

5. 回頭看上一段虛擬函式OnThresholdReached中(Line 25)，ThresholdReached如果非空(handler!=null, 因為handler即ThresholdReached)，則執行該委派handler(this, e)，其中this即Counter這個類別實體c本身，e則為傳入事件參數(包含門檻值和達門檻時間)。

6. 這一切成立條件為total>=threshold，實體化事件參數(args = new ThresholdReachEventArgs)，呼叫OnThresholdReached(args)

 1: static void Main(string[] args)
   2:        {
   3:            int threshold = new Random().Next(10);
   4:            string info = string.Format("threshold = {0}", threshold);
   5:            Console.WriteLine(info);
   6:            Counter c = new Counter(threshold);
   7:            c.ThresholdReached += c_ThresholdReached;
   8:            Console.WriteLine("press 'a' key to increase total");
   9:            while (Console.ReadKey(true).KeyChar == 'a')
  10:            {
  11:                Console.WriteLine("adding one");
  12:                c.Add(1);
  13:            }
  14:        }
  15:  
  16:        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
  17:        {
  18:            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
  19:            Environment.Exit(0);
  20:        }
  
  
   https://msdn.microsoft.com/zh-tw/library/system.eventhandler(v=vs.110).aspx




