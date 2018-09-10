https://blog.davy.tw/archives/413

什麼是 Singleton？（以 C# 為例）

//=======================================================
using System;

class SingletonA {
    private static SingletonA instance = null;

    public static SingletonA Instance {
        get {
            return instance ?? new SingletonA();
        }
    }

    private SingletonA() {
        instance = this;
    }
}
//====  改良  ===================================================

using System;

class sealed SingletonB {
    private static SingletonB instance = null;

    public static SingletonB Instance {
        get {
            if (instance == null) {
                instance = new SingletonB();
            }
            return instance;
            // 或寫成下列寫法
            // return instance ?? (instance = new SingletonB());
        }
    }

    private SingletonB() { }
}

//====== 多執行緒？ =====================================================
//== Static Initialization===

using System;

class sealed SingletonC {
    private static readonly SingletonC instance = new SingletonC();

    public static SingletonC Instance {
        get {
            return instance;
        }
    }

    private SingletonC() { }
}

//===== 使用鎖 ====================
using System;

class sealed SingletonD {
    private static volatile SingletonD instance;
    private static object syncRoot = new Object();

    public static SingletonD Instance {
        get {
            if (instance == null) {
                lock (syncRoot) {
                    if (instance == null) {
                        instance = new SingletonD();
                    }
                }
            }

            return instance;
        }
    }

    private SingletonD() { }
}




