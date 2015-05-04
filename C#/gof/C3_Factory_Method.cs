//https://sourcemaking.com/design_patterns/factory_method
using System;
using System.Collections;

namespace C3_factory_method {
    class MainApp {
        static void Main1() {
            // An array of creators 
            Creator[] creators = {new ConcreteCreatorA(), 
                                 new ConcreteCreatorB()};

            // Iterate over creators and create products 
            foreach (Creator creator in creators) {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            // Wait for user 
            Console.Read();
        }
    }

    abstract class Product { }
    class ConcreteProductA : Product { }
    class ConcreteProductB : Product { }

    abstract class Creator {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator {
        public override Product FactoryMethod() {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator {
        public override Product FactoryMethod() {
            return new ConcreteProductB();
        }
    }
}