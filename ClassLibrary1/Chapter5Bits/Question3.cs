using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Bits
{
    public class Question3
    {
        public int BruteForce(int input)
        {
            int length = 0;
            List<int> lengths = new List<int>();

            BitArray bArray = new BitArray(new int[] { input });
            int[] bits = bArray.Cast<bool>().Select(bit => bit ? 1 : 0).ToArray();

            
            foreach(int b in bits)
            {
                if(b == 1)
                {
                    length++;
                }
                else
                {
                    lengths.Add(length);
                    length = 0;
                }
            }



            return lengths.Max();
        }

        public int Optimal(int input)
        {
            return 0;

        }
    }
}
