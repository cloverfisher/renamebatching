using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameBatching
{
    public class Folder
    {
        public List<MyFile> myfile = new List<MyFile>();
        int length;
        string path;

        public Folder(String[] s)
        {

            int i = 0;
       //     String temps;
            length = s.Length ;
            while (i<s.Length)
            {
       //         temps = ;
                myfile.Add(new MyFile(s[i]));
                i++;               
            }
            path = myfile[0].getpath();
        }

        public string getName()
        {
            return myfile[0].getFileName();
        }

        public string getFirstFileName()
        {
            return myfile[0].getPreName();
        }

        public string getExpName()
        {
            return myfile[0].getExpandName();
        }

        public int getLength()
        {
            return length;
        }

        public string getpath()
        {
            return path;
        }
    }
}
