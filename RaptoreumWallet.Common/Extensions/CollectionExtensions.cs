using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace RaptoreumWallet.Common.Extensions
{
    public static class CollectionExtensions
    {
        public static bool HasElementGreaterThanZero(this IEnumerable<int> collection)
        {
            return HasElementGreaterThanZero((IEnumerable<double>)collection);
        }
        public static bool HasElementGreaterThanZero(this IEnumerable<decimal> collection)
        {
            if (collection == null)
                return false;
            return collection.Any(d => d > 0);
        }
        public static bool HasElementGreaterThanZero(this IEnumerable<double> collection)
        {
            if (collection == null)
                return false;
            return collection.Any(d => d > 0);
        }

        public static void RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match)
        {
            if (collection == null)
            {
                collection = new ObservableCollection<T>();
                return;
            }
            var lstRemove = new List<T>();
            for (int i = 0; i < collection.Count; i++)
            {
                var obj = collection[i];
                var m = match.Invoke(obj);
                if (m)
                {
                    lstRemove.Add(obj);
                }
            }
            for (int i = 0; i < lstRemove.Count; i++)
            {
                collection.Remove(lstRemove[i]);
            }
        }

        public static void AddRange<T>(this ObservableCollection<T> collection, IList<T> lst)
        {
            if (lst == null)
                return;
            if (collection == null)
            {
                collection = new ObservableCollection<T>(lst);
                return;
            }
            for (int i = 0; i < lst.Count; i++)
            {
                collection.Add(lst[i]);
            }
        }

        public static void DictionaryConcat<TK, TV>(this Dictionary<TK, TV> source, Dictionary<TK, TV> d2)
        {
            if (d2 == null || source == null)
                return;
            for (int i = 0; i < d2.Keys.Count; i++)
            {
                var key = d2.Keys.ElementAt(i);
                if (source.ContainsKey(key))
                    continue;
                source.Add(key, d2[key]);
            }
        }

        public static void DictionaryConcat<TK, TV>(this Dictionary<TK, TV> source, List<KeyValuePair<TK, TV>> d2)
        {
            if (d2 == null || source == null)
                return;
            for (int i = 0; i < d2.Count; i++)
            {
                var kp = d2[i];
                if (source.ContainsKey(kp.Key))
                    continue;
                source.Add(kp.Key, kp.Value);
            }
        }

        public static void RemoveAll<TK, TV>(this Dictionary<TK, TV> source, List<TK> keys)
        {
            if (keys == null)
                return;
            for (int i = 0; i < keys.Count; i++)
            {
                var key = keys[i];
                if (!source.ContainsKey(key))
                    continue;
                source.Remove(key);
            }
        }

        public static decimal GetValue(this Dictionary<string, decimal> dic, string key)
        {
            if (dic == null || string.IsNullOrEmpty(key))
                return 0m;
            var k = dic.Keys.FirstOrDefault(d => d.ToLower().Equals(key.ToLower()));
            if (string.IsNullOrEmpty(k))
            {
                return 0m;
            }
            return dic[k];
        }

        public static T GetValue<T>(this IEnumerable<T> lst, int index)
        {
            if (lst == null || lst.Count() <= index)
                return default(T);
            return lst.ElementAt(index);
        }

        public static T GetValue<T>(this IList<T> lst, int index)
        {
            if (lst == null || lst.Count <= index)
                return default(T);
            return lst[index];
        }


        public static TV GetValue<TV>(this Dictionary<string, TV> dic, string currency)
        {
            if (dic == null || string.IsNullOrEmpty(currency) || !dic.ContainsKey(currency))
            {
                return default(TV);
            }
            return dic[currency];
        }

        public static TV GetValue<TK, TV>(this Dictionary<TK, TV> dic, TK currency)
        {
            if (dic == null || currency == null || !dic.ContainsKey(currency))
            {
                return default(TV);
            }
            return dic[currency];
        }

        public static TValue TryGet<TValue>(this IDictionary<string, object> dic, string key)
        {
            return TryGet<string, TValue>(dic, key);
        }

        public static TValue TryGet<TKey, TValue>(this IDictionary<TKey, object> dic, TKey key)
        {
            object value;
            if (dic.TryGetValue(key, out value))
            {
                if (value is OnPlatform<TValue> on)
                {
                    return (TValue)on.Platforms.FirstOrDefault(d => d.Platform.Contains(Device.RuntimePlatform)).Value;
                }
                return (TValue)value;
            }
            return default(TValue);
        }

        public static bool ChangeIndex<T>(this IList<T> lst, int toIndex, T item)
        {
            if (lst.Contains(item) == false)
            {
                return false;
            }

            lst.Remove(item);
            lst.Insert(toIndex, item);

            return true;
        }

        public static bool ChangeIndex<T>(this IList<T> lst, int oldindex, int newIndex)
        {
            if (Math.Max(oldindex, newIndex) >= lst.Count)
            {
                return false;
            }
            var item = lst[oldindex];
            lst.Remove(item);
            lst.Insert(newIndex, item);

            return true;
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> lst)
        {
            return lst == null || lst.Count() == 0;
        }

        private static readonly Random rd = new Random();

        public static IList<T> MakeRandom<T>(this IList<T> arr)
        {
            lock (rd)
            {
                var lst = new List<T>();
                while (arr.Count > 0)
                {
                    var index = rd.Next(arr.Count - 1);
                    var obj = arr[index];
                    lst.Add(obj);
                    arr.Remove(obj);
                }
                return lst;
            }
        }
    }
}
