using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_State {
    class MainApp {
        public static void Maini() {
            Context c = new Context();
            State[] states = { new State1(), new State2(), new State3() };
            foreach (State s in states) {
                c.setState(s);
                c.Request();
            }
            Console.In.Read();
        } 
    }

    interface State {
        void Handle();
    }

    class Context {
        State state;
        public void setState(State s) {
            this.state = s;
        }
        public void Request() {
            if (state != null) {
                state.Handle();
            }
        }
    }

    class State1 : State {
        public void Handle(){
            Console.Out.WriteLine("State 1 is handled");
        }
    }

    class State2 : State {
        public void Handle(){
            Console.Out.WriteLine("State 2 is handled");
        }
    }

    class State3 : State {
        public void Handle(){
            Console.Out.WriteLine("State 3 is handled");
        }
    }
}
