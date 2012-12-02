using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RenameBatching
{
    public class MyFile
    {
        private string fileName;
        string filePath;
        string filePreName;
        string fileExpName;
        int extdot;
        int doubleSlashPath;
        int fileLength;


        public MyFile(string name)
        {
            this.fileName = name;
         
            analyzName(fileName);

           
            fileExpName = fileName.Substring(extdot+1);
            filePath = fileName.Substring(0, doubleSlashPath);
            filePreName = fileName.Substring(doubleSlashPath+1, extdot - doubleSlashPath-1 );
        }


        public void analyzName(string name)
        {

            fileLength = name.Length;
            extdot = name.LastIndexOf(".");
            doubleSlashPath = name.LastIndexOf("\\");
        }

        public string getFileName()
        {
            return fileName;
        }

        public string getPreName()
        {
            return filePreName;
        }

        public string getExpandName()
        {
            return fileExpName;
        }

        public string getpath()
        {
            return filePath;
        }
    }
}
