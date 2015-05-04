using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace S6_Flyweight {
    public class MainAPP {
        public static void Main1(){
            int key = 100;
            FlyweightFactory ff = new FlyweightFactory();
            Flyweight fw = ff.getFlyweight(--key);
            while(key > 0){
                fw = ff.getFlyweight(--key);
                fw.Operation(key);
            }
            Console.In.Read();
        }
    }

    class FlyweightFactory {
        Dictionary<int, Flyweight> hash = new Dictionary<int, Flyweight>();
        public Flyweight getFlyweight(int key){
            Flyweight fw = null;
            if (hash.ContainsKey(key)) {
                fw = hash[key];
            } else {
                fw = new ConcreteFlyWeight();
                hash[key] = fw;
            }
            return fw;
        }
    }

    abstract class Flyweight {
        public abstract void Operation(int extrsinicState);
    }

    class ConcreteFlyWeight : Flyweight{
        int intrinsicState = 1;
        public override void Operation(int extrsinicState) {
            Console.Out.WriteLine("ConcreteFlyWeight is called");
        }
    }

    class UnsharedConcreteFlyWeight : Flyweight {
        int allState = 2;
        public override void Operation(int extrsinicState) {
            Console.Out.WriteLine("UnsharedConcreteFlyWeight is called");
        }
    }
}
