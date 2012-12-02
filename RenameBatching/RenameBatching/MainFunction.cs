using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace RenameBatching
{
    class MainFunction
    {
        public void reName(Folder folder1, Folder folder2)
        { 
            for(int i = 0 ; i < folder1.getLength(); i++)
            {
                  fileRename(folder1.myfile[i].getFileName(),folder2.myfile[i].getFileName());
            }

        }

        public void fileRename(String a, String b)
        {
   //         File.Move("D:\\test\\a.txt", "D:\\test\\a2.txt");
            File.Move(a,b);
  //          FileInfo ainfo = new FileInfo(a);
 //           moveFile(ainfo, b);
        }


        public void moveFile(FileInfo fInfo ,String destPath)
        {
            
            try
            {
                fInfo.MoveTo(destPath);
                Console.WriteLine("File moved to ");
                Console.WriteLine(destPath);
            }
            catch (Exception ex)
            {
            // DisplayException(ex);
            }
        }

        public Folder creatNewFolder(Folder afolder, int num, string name1, string name2)
        {
            string apath = afolder.getpath() ;
            int anum = num;
            int length = afolder.getLength();
            String[] newname ;
            newname = new string[length];
            for (int i = 0; i < length ; i++ )
            {
                newname[i] = apath +"\\" + name1 + anum.ToString()+ "." + name2;
                anum ++;
            }
            Folder newfolder = new Folder(newname);
            return newfolder;
            
        }




    }
}
