using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7z3
{
    class Tekst
    {
        public String[] sentence = new String[100];
        public int length = 0;
        public String this[int ix]
        {
            get { return sentence[ix]; }
            set { sentence[ix] = value; }
        }
        

        public Tekst(String sentence)
        {
            this.sentence = sentence.Split(' ');
            foreach(var word in sentence.Split(' '))
            {
                length++;
            }
        }

    }
}
