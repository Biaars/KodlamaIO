using System;
using System.Collections.Generic;
using System.Text;

namespace List_Dictionary_Day4
{
    class Dictionary<Tkey,Tvalue>
    {
            Tkey []
            keys;
            Tvalue []
            values;

        public Dictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];

        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempTkey = keys;
            keys = new Tkey[keys.Length + 1];
            Tvalue[] tempTvalue = values;
            values = new Tvalue[values.Length + 1];
            for (int i = 0; i < tempTkey.Length; i++)
            {
                keys[i] = tempTkey[i];
                values[i] = tempTvalue[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public Tkey[] key { get { return keys; } }
        public Tvalue[] value { get { return values; } }
        
        public int Length { get { return keys.Length; } }



    }
}
