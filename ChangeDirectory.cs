using System;
using System.Collections.Generic;
using System.Text;

namespace Meddiff
{
    class Path
    {
        public String current_path;
        List<String> list = new List<string>();
        public Path(String path)
        {
            String[] str = path.Split("/");
            foreach(String dir in str)
            {
                if(dir.Trim().Length > 0)
                    list.Add(dir);
            }
            current_path = path;
        }

        public void cd(String next)
        {
            current_path = "";
            String[] str = next.Split("/");
            foreach (String dir in str)
            {
                if(dir == "..")
                {
                    if(list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                else if(dir != ".")
                    list.Add(dir);
            }

            foreach(String dir in list)
            {
                if(dir.Trim().Length > 0)
                {
                    current_path += "/";
                    current_path += dir;
                }                
            }
            if(current_path.Trim().Length < 1)
            {
                current_path = "/";
            }
        }

    }
}
