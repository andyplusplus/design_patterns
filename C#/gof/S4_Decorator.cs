using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_Decorator {
    class MainApp {
        static void Main1() {
            Component c = new ConcreteDecoratorA(null, "add some bread, ");
            c = new ConcreteDecoratorB(c, "with milk");
            c = new ConcreteDecoratorA(c, "with butter");
            c.Operation();
            Console.In.ReadLine();
        }

    }

    abstract class Component {
        public abstract void Operation();
    }

    class ConcreteComponent : Component {
        string name = "";
        ConcreteComponent(string name) { this.name = name; }
        public override void Operation() {
            Console.Out.WriteLine("{0}   is running");
        }
    }

    //decorator class decorate existing class
    abstract class Decorator : Component {
        protected Component component = null;
        public void setComponent(Component c) { this.component = c; }
        public override void Operation() {
            if (component != null) {
                component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decorator{
        private string extraState = "extra state";
        protected string info = "";
        public ConcreteDecoratorA(Component c = null, string info = "") { this.component = c; this.info = info; }
        public override void Operation() {
            base.Operation();
            Console.Out.WriteLine(" decorator->{0} with {1}", info, extraState);
        }
    }

    class ConcreteDecoratorB : Decorator {
        protected string info = "";
        public ConcreteDecoratorB(Component c = null, string info = "") { this.component = c; this.info = info; }
        public override void Operation() {
            base.Operation();
            Console.Out.WriteLine(" decorator->{0} with added behavior", info);
            AddedBehavior();
        }

        private void AddedBehavior() {
            Console.Out.WriteLine("        Added Behavior");
        }
    }


}
