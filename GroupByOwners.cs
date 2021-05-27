using System;
using System.Collections.Generic;
using System.Text;

namespace Meddiff
{
    class GroupByOwners
    {
        public GroupByOwners()
        {

        }

        //static void Main(string[] args)
        //{
        //    GroupByOwners inst = new GroupByOwners();
        //    inst.check();            
        //}

        public void check()
        {
            Dictionary<String, String> map = new Dictionary<string, string>();
            map.Add("Input.txt", "Randy");
            map.Add("Code.py", "Stan");
            map.Add("Output.txt", "Randy");
            Dictionary<String, List<String>> res = group(map);
            foreach(String key in res.Keys)
            {
                Console.WriteLine("Key: " + key);
                foreach(String value in res[key])
                {
                    Console.WriteLine("         Value: " + value);
                }
            }
        }

        private Dictionary<String, List<String>> group(Dictionary<String, String> map)
        {
            Dictionary<String, List<String>> res = new Dictionary<String, List<String>>();

            foreach(String key in map.Keys)
            {
                if(!res.ContainsKey(map[key]))
                {
                    res.Add(map[key], new List<string>());
                }
                res[map[key]].Add(key);
                //List<String> sub = res[map[key]];
                //sub.Add(key);
                //res.Add(map[key], sub);
            }

           return  res;
        }
    }
}
