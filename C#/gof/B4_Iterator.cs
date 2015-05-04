using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Iterator{
    class AppMain{
        static void Main1() {
            Aggregate<int> a = new ArrayAggregate<int>();
            Iterator<int> ai = a.createIterator();
            for(; ai.isDone(); ai.Next()){
                int? i = ai.CurrentItem();
            }
        }
    }

    class Person { }

    interface Aggregate<T> {
        Iterator<T> createIterator();
    }
    class ArrayAggregate<T> : Aggregate<T> {
        int[] datas = new int[10];
        public Iterator<T> createIterator() {
            return null;
        }
    }

    interface Iterator<T>{
        T First();
        T Next();
        bool isDone();
        T CurrentItem();
    }
    class ArrayIterator<T> {
        T obj;
        ArrayIterator(ArrayAggregate<T> a) { }
        public T First() {
            return obj;
        }
        T Next(){
            return obj;
        } 
        bool isDone(){
            return false;
        } 
        T CurrentItem(){
            return obj;
        } 
    }
}
