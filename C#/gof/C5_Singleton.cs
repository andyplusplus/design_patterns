using System;

namespace C5_singletone {
    class MainApp {

        static void Main1() {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2) {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user 
            Console.Read();
        }
    }

    // "Singleton" 
    class Singleton {
        private static Singleton instance;

        // Note: Constructor is 'protected' 
        protected Singleton() { }

        public static Singleton Instance() {
            if (instance == null) {      // Use 'Lazy initialization' 
                instance = new Singleton();
            }
            return instance;
        }
    }
}