using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriekeCollecties
{
    internal class Stapel <T>
    {
        List <T> container;

        internal Stapel()
        {
            container = new List <T>();
        }

        public void Opzetten(T i)
        {
            container.Add(i);
        }

        public T Afhallen()
        {

            T even = container[0];
            container.RemoveAt(0);
            return even;
        }

        public void LeegMaken()
        {
            container.Clear();
        }

        public override string ToString()
        {
            string s = "";

            foreach (T i in container)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }
    }
}
