using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T leftEl, T rightEl)
        {
            this.left = leftEl;
            this.right = rightEl;
        }
        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }
}
