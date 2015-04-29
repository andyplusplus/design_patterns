using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gof.abstract_factory.structure {
    #region IProductA, IProductB, IFactory
    interface AbstractProductA { }

    interface AbstractProductB { }

    interface AbstractFactory {
        AbstractProductA createProductA();
        AbstractProductB createProductB();
    }
    #endregion

    #region ProductA1, ProductB1
    class ProductA1 : AbstractProductA{ }
    class ProductA2 : AbstractProductA{ }

    class ProductB1 : AbstractProductB { }
    class ProductB2 : AbstractProductB { }
    #endregion

    #region Factory
    class Factory1 : AbstractFactory {
        AbstractProductA createProductA() { return new ProductA1(); }
        AbstractProductB createProductB() { return new ProductB1(); }
    }

    class Factory2 : AbstractFactory {
        AbstractProductA createProductA() { return new ProductA2(); }
        AbstractProductB createProductB() { return new ProductB2(); }
    }
    #endregion



    class Abstract_Factory_Client {
        public Abstract_Factory_Client(AbstractFactory factory){
            AbstractProductA pA = factory.createProductA();
            AbstractProductB pB = factory.createProductB();
            // do something with productA, productB
        }
    }

}
