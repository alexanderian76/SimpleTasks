using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp20
{
    class KeyValueCompare
    {
        Hashtable _Hash = new Hashtable();
        public KeyValueCompare()
        {

        }

        public KeyValueCompare(Hashtable hash)
        {
            _Hash = hash;
        }
        
        public bool CompareHash(object hash1, object hash2)
        {
           return hash1.GetHashCode() == hash2.GetHashCode();
        }
    }
}
