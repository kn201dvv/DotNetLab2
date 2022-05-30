using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab2
{
 public class dictionaryEx<T, U, V>
    {
        public class ExtendedDictionaryElement<T, U, V>
        {
            public T Key { get; set; }
            public U Value1 { get; set; }
            public V Value2 { get; set; }
        }
        
        public List<ExtendedDictionaryElement<T, U, V>> useList = new
        List<ExtendedDictionaryElement<T, U, V>>();
        public void Add(T key, U value1, V value2)
        {
            lock (useList)
                useList.Add(new ExtendedDictionaryElement<T, U, V>()
                {
                    Key = key,
                    Value1 = value1,
                    Value2 = value2
                });
        }
        public void Delete(T key)
        {
            lock (useList)
                useList.Remove(useList.First((a) => a.Key.Equals(key)));
        }
        public bool isKey(T key)
        {
            lock (useList)
            {
                if ((useList.FirstOrDefault((a) => a.Key.Equals(key))) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool isValueOne(U value)
        {
            lock (useList)
            {
                if (useList.FirstOrDefault((a) => a.Value1.Equals(value)) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool isValueTwo(V value)
        {
            lock (useList)
            {
                if (useList.FirstOrDefault((a) => a.Value2.Equals(value)) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public ExtendedDictionaryElement<T, U, V> this[int index]
        {
            get => useList[index];
            set => useList[index] = value;
        }
        public ExtendedDictionaryElement<T, U, V> getByKey(T key)
        {
            lock (useList)
            {
                return useList.First((a) => a.Key.Equals(key));
            }
        }
        public int Count()
        {
            lock (useList)
            {
                int count = 0;
                foreach (var elem in useList)
                {
                    count++;
                }
                return count;
            }
        }
        public string ElementString(ExtendedDictionaryElement<T, U, V> elem)
        {
           return elem.Key.ToString() + " " + elem.Value1.ToString() + " " +
           elem.Value2.ToString();
        }
    }
}


    
