using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Proxy {
    class MainApp {
        public static void Main1() {
            Subject s = new RealSubject();
            Subject p = new Proxy(s);
            p.Request();
            Console.In.Read();
        }   
   } 

    abstract class Subject {
        public abstract void Request();
    }

    class RealSubject : Subject {
        public override void Request() {
            Console.Out.WriteLine("real Subject is called");
        }
    }

    class Proxy : Subject { 
        Subject s; 
        public Proxy(Subject s) {
            this.s = s;
        }
        public override void Request() {
            s.Request();
        }
    }//Proxy
}
