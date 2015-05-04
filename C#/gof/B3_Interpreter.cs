using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_Interpreter {
    class MainApp {
    }

    class Context { }

    abstract class AbstractExpression {
        public abstract void Interpret(Context c);
    }

    class TerminalExpression : AbstractExpression {
        public override void Interpret(Context c) {
            Console.Out.WriteLine("terminal called");
        }
    }

    class NonterminalExpression : AbstractExpression {
        private AbstractExpression exp;
        public override void Interpret(Context c) {
            Console.Out.WriteLine("nonterminal called");
        }
    }
}
