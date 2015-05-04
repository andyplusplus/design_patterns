using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Observer {
    class B7_Observer {
        public static void Main1() {
            Subject s = new ConcreteSubject();
            Observer[] os = { new ConcreteObserver(s), new ConcreteObserver(s), new ConcreteObserver(s) };
            s.Notify();
            Console.In.Read();
        }
    }

    interface Observer{
        void Update();
    }

    abstract class Subject {
        protected List<Observer> observers = new List<Observer>();
        public void attach(Observer o) {
            observers.Add(o);
        }
        public void detach(Observer o) {
            observers.Remove(o);
        }
        public void Notify() {
            foreach (Observer o in observers) {
                o.Update();
            }
        }
        public int subjectState { set; get; }
    }
    class ConcreteSubject : Subject {
    }

    class ConcreteObserver : Observer {
        int observerState;
        Subject s;
        public ConcreteObserver(Subject s) {
            this.s = s;
            s.attach(this);
        }
        public void Update() {
            observerState = s.subjectState;
            Console.Out.WriteLine(observerState);
        }
    }
}
