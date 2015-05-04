using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9_Strategy {
    class MainApp {
    }

    //the context can run with different algirhtms
    class Context {
        Strategy strategy;
        public void setStrategy(Strategy s) {
            this.strategy = s;
        }
        public void Run() {
            strategy.AlgorithmInterface();
        }
    }
    interface Strategy {
        void AlgorithmInterface();
    }
    class ConcreteStrategyA : Strategy {
        public void AlgorithmInterface() {
            Console.Out.WriteLine("This is algorithm ... A");
        }
    }
    class ConcreteStrategyB : Strategy {
        public void AlgorithmInterface() {
            Console.Out.WriteLine("This is algorithm ... B");
        }
    }
    class ConcreteStrategyC : Strategy {
        public void AlgorithmInterface() {
            Console.Out.WriteLine("This is algorithm ... C");
        }
    }

}
