using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_Command{
    class MainApp {
        public static void Main1(){
            Receiver recvr = new ConcreteReceiver();
            Command c1 = new ConcreteCommand(recvr);
            Command c2 = new ConcreteCommand(recvr);
            //invoke command now
            Invoker inv = new Invoker();
            inv.setCommand(c1);
            inv.invoke();
            inv.setCommand(c2);
            inv.invoke();
            Console.In.Read();
        }
    }


    class Invoker {
        private Command cmd;
        public void setCommand(Command cmd) {
            this.cmd = cmd;
        }
        public void invoke() {
            this.cmd.Execute();
        }
    }

    interface Receiver {
        void Action();
    }
    class ConcreteReceiver : Receiver {
        public void Action() {
            Console.Out.WriteLine("action is taked");
        }
    }


    interface Command {
        void Execute();
    }
    class ConcreteCommand : Command {
        Receiver recvr;
        public ConcreteCommand(Receiver recvr) {
            this.recvr = recvr;
        }
        public void Execute() {
            this.recvr.Action();
        }
    }
}
