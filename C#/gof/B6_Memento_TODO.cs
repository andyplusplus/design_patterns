using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_Memento_TODO {
    class MainApp {
    }

    class Originator {
        State state;
        public void setMemento(State s){
            this.state = s;
        }
        public Memento createMemento(){
            return new Memento(state);
        }
    }

    class Memento {
        public Memento(State state) {
            this.state = state;
        }
        public State state {set; get;}
    }

    class State { }
}
