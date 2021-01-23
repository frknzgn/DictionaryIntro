using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("furkan", "ozgun");
            myDictionary.Add("Engin", "Demirog");

            //Console.WriteLine(myDictionary);

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(1, "bir");
            myDictionary2.Add(2, "iki");
            
            //Console.WriteLine(myDictionary2);
        
        }
    }

    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey item,TValue value)
        {
            TKey[] tempArrayKey = _keys;
            _keys = new TKey[_keys.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _keys[i] = tempArrayKey[i];
            }
            _keys[tempArrayKey.Length] = item;



            TValue[] tempArrayValue = _values;
            _values = new TValue[_values.Length + 1];
            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                _values[i] = tempArrayValue[i];
            }
            _values[tempArrayValue.Length] = value;
        }


    }
}



