using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_Chains_of_Responsibility{
    class MainApp{
        public static void Main1() {
            Handler handler = new ConcreteHandler1(new ConcreteHandler2(null, "two"), "one");
            handler.HandleRequest("one");
            handler.HandleRequest("two");
            handler.HandleRequest("three");
            Console.In.Read();
        }
    }

    abstract class Handler {
        protected Handler successor;
        public abstract void HandleRequest(string request);
    }

    class ConcreteHandler1 : Handler{
        private string state;
        public ConcreteHandler1(Handler successor, string state) {
            this.successor = successor;
            this.state = state;
        }
        public override void HandleRequest(string request) {
            if (state == request) {
                Console.Out.WriteLine("request is handled by concreteHandler" + request);
            } else if (successor != null) {
                successor.HandleRequest(request);
            } else {
                Console.Out.WriteLine("!!!no one handles the request");
            }
        }//HandleRequest
    }//class

    class ConcreteHandler2 : Handler{
        private string state;
        public ConcreteHandler2(Handler successor, string state) {
            this.successor = successor;
            this.state = state;
        }
        public override void HandleRequest(string request) {
            if (state == request) {
                Console.Out.WriteLine("request is handled by concreteHandler" + request);
            } else if (successor != null) {
                successor.HandleRequest(request);
            } else {
                Console.Out.WriteLine("!!!no one handles the request");
            }
        }//HandleRequest
    }//class


}
