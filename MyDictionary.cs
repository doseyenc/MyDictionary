using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }    
        public void add(K key , V Value)
        {
            
            int index =isContain(key);
                if (index!=-1)
                { 
                //Eğer key halihazırda keys arrayinde mevcutsa 
                //yeni bir entry olarak eklemek yerine var olan keyin valuesi güncellenir
                    values[index] = Value;
                }
                else
                {
                //Eğer gelen key Keys arrayinde mevcut değilse key value yeni bir entry olarak eklenir.
                //Ve arraylerin boyutu yeni entry için büyütülür.
                    K[] tmpKeys = keys;
                    V[] tmpValues = values;
                    keys = new K[keys.Length + 1];
                    values = new V[values.Length + 1];
                    for (int i = 0; i < tmpKeys.Length; i++)
                    {
                        keys[i] = tmpKeys[i];
                        values[i] = tmpValues[i];
                    }
                    keys[keys.Length - 1] = key;
                    values[values.Length - 1] = Value;
                }
        }
        public int isContain(K key)
        {
        //Parametre olarak gelen key keys arrayinde varsa bulunduğu indexi yoksa -1 döndüren method.
            int index = -1;
            for(int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    index = i;
                    break;//İlk bulduğu indexi döner.
                }
            }

            return index;


        }
        public void print()
        {
            for(int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("plaka : "+keys[i]+" il : "+values[i]);
            }
        }
        public void getKeys()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]);
            }
        }
        public void getValues()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }


    }
}
