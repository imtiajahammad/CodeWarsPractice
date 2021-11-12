using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsPractice
{
    public class ListFiltering
    {
        public ListFiltering()
        {
            //List<object> listOfItems = new List<object>() { 1, 2, "a", "b" };
            //List<object> listOfItems = new List<object>() { 1, 2, "a", "b", 0, 15 };
            List<object> listOfItems = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            IEnumerable<int> returnlist = GetIntegersFromList(listOfItems);
            foreach(int a in returnlist)
            {
                Console.Write(a + " ");
            }
            /*ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }) => { 1, 2}
            ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
            ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }) => { 1, 2, 231}*/
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> list = new List<int>();
            foreach(object a in listOfItems)
            {
                if(a.GetType()== typeof(int))
                {
                    list.Add(Convert.ToInt32(a));
                }
            }
            return list;
        }
        public IEnumerable<int> GetIntegersFromList2(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
        public IEnumerable<int> GetIntegersFromList3(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().Cast<int>();
        }
        public IEnumerable<int> GetIntegersFromList4(List<object> listOfItems)
        {
            List<int> results = new List<int>();

            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    results.Add((int)item);
                }
            }

            return results;
        }
    }
}
