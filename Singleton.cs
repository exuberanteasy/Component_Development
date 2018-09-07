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
