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

//============================================================

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





//============================================================
https://blog.davy.tw/archives/413




