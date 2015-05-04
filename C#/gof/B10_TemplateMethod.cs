using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10_TemplateMethod {
    class MainApp{
    }
    abstract class AbstractClass{
        public void TemplateMethod() {
            Console.Out.WriteLine("something");
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
            Console.Out.WriteLine("something");
        }
        abstract protected void PrimitiveOperation1();
        abstract protected void PrimitiveOperation2();
    }
    class ConcreteClass1 : AbstractClass {
        protected void PrimitiveOperation1() {
            Console.Out.WriteLine("PrimitiveOperation1");
        }
        protected void PrimitiveOperation2() {
            Console.Out.WriteLine("PrimitiveOperation2");
        }
    }//class
}
