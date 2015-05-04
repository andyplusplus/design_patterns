using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Composite {
    public class MainAPP {
        public static void Main1() {
            Component root = new Composite();
            root.Add(new Leaf())
                .Add(
                new Composite().Add(new Composite()).Add(new Leaf()));

            root.Operation();
            Console.In.ReadLine();
        }
    }

    abstract class Component {
        public List<Component> children = null;
        public virtual void Operation() {
            Console.Out.Write("  ");
        }
        public virtual Component Add(Component c) {
            if (children == null) {
                children = new List<Component>();
            }
            children.Add(c);
            return this;
        }
        public virtual void Remove(Component c) {
            if (children != null) {
                children.Remove(c);
            }
        }
        public virtual Component getChild(int i) {
            return children[i];
        }
    }

    class Leaf : Component {
        static int index = 0;
        public override void Operation() {
            Console.Out.WriteLine("I am leaf {0}", index++);
        }
    }

    class Composite : Component {
        static int index = 0;
        public override void Operation() {
            for (int i = 0; i < index; i++) {
                base.Operation();
            }
            Console.Out.WriteLine("I am Composite {0}", index++);
            if (children != null) {
                foreach (Component c in children) {
                    c.Operation();
                }
            }
        }//operation
    }//class

}