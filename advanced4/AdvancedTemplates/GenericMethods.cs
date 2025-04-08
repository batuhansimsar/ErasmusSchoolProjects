using System;
using System.Collections.Generic;

namespace AdvancedTemplates
{
    public static class GenericMethods
    {
        // 1. Swap method
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // 2. Display types method
        public static void DisplayTypes<T1, T2>(T1 param1, T2 param2)
        {
            Console.WriteLine($"Type 1: {typeof(T1).Name}, Value: {param1}");
            Console.WriteLine($"Type 2: {typeof(T2).Name}, Value: {param2}");
            param1 = default;
            param2 = default;
        }

        // 3. Create instance method
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        // 4. Get larger value method
        public static T GetLarger<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // 5. Sort parameters method
        public static List<T> SortParameters<T>(params T[] parameters) where T : IComparable<T>
        {
            List<T> list = new List<T>(parameters);
            list.Sort();
            return list;
        }

        // 6. Create dictionary method
        public static Dictionary<TKey, TValue> CreateDictionary<TKey, TValue>(TKey key, TValue value) 
            where TKey : struct 
            where TValue : class
        {
            var dict = new Dictionary<TKey, TValue>();
            dict.Add(key, value);
            return dict;
        }

        // 7. Display dictionary method
        public static void DisplayDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

        // 8. Queue or Stack method
        public static IEnumerable<T> CreateCollection<T>(params T[] items)
        {
            if (items.Length < 3)
                return new Queue<T>(items);
            else
                return new Stack<T>(items);
        }
    }
}
