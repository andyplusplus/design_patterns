using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_Mediator {
    class MainApp{
        static void Main1() {
            Mediator m = new ConcreteMediator();
            Colleague c = new ConcreteColleague1(m);
            Colleague c1 = new ConcreteColleague2(m);
            Console.In.Read();
        }
    }

    interface Mediator {
        void add(Colleague c);
        void remove(Colleague c);
    }

    class ConcreteMediator : Mediator {
        List<Colleague> list = new List<Colleague>();
        public void add(Colleague c){
            this.noitfyAll();
            list.Add(c);
        }
        public void remove(Colleague c){
            list.Remove(c);
            this.noitfyAll();
        }
        private void noitfyAll(){
            foreach (Colleague c0 in list) {
                c0.notify();
            }
        }
    }//class

    abstract class Colleague {
        protected Mediator mediator;
        public abstract void notify();
    }
    class ConcreteColleague1 : Colleague{
        public ConcreteColleague1(Mediator m) {
            this.mediator = m;
        }
        public override void notify() {
            Console.Out.WriteLine("somebody join or leave");
        }
    }

    class ConcreteColleague2 : Colleague{
        public ConcreteColleague2(Mediator m) {
            this.mediator = m;
        }
        public override void notify() {
            Console.Out.WriteLine("somebody join or leave");
        }
    }
}
