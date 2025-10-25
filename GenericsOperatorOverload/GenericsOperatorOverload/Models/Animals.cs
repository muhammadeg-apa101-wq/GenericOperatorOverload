using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsOperatorOverload.Models
{
    public class Animals
    {
        public int Count { get; set; }

        public Animals(int count)
        {
            Count = count;
        }

        public static bool operator >(Animals a1, Humans a2)
        {
            return a1.Count > a2.Count;
        }

        public static bool operator <(Animals a1, Humans a2)
        {
            return a1.Count < a2.Count;
        }
    }
}
