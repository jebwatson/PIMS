using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSTests.Helpers
{
    public interface ICompare<in T>
    {
        /// <summary>
        /// Compare two objects.
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        void Compare(T obj1, T obj2);
    }
}
