using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace RenameBatching
{
    public class MainFunction
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
            try
            {
                File.Move(a, b);
            }
            catch(FileNotFoundException)
            {
            
            }
            finally
            { 
            
            }
             

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

        public Folder creatNewFolder(Folder afolder, string num, string name1, string name2,string prefixname,string postfixname)
        {
            string apath = afolder.getpath() ;
            
            int length = afolder.getLength();
            String[] newname ;
            newname = new string[length];
            if (num != "")
            {
                int anum = Convert.ToInt32(num);
                for (int i = 0; i < length; i++)
                {
                    newname[i] = apath + "\\" + prefixname + name1 + anum.ToString() + postfixname + "." + name2;
                    anum++;
                }
            }
            if (num == "")
            {
                for (int i = 0; i < length; i++)
                {
                    newname[i] = apath + "\\" + prefixname + name1 + postfixname + "." + name2;
                }
            }

            Folder newfolder = new Folder(newname);
            return newfolder;
            
        }


        public void openFolder(string s)
        {
            System.Diagnostics.Process.Start("explorer.exe", s);
        }

        public bool wheRename(Folder mf, String s1, String s2, String s3)
        {
            if (mf == null)
                return false;
            if (mf.getLength() == 0)
                return false;
            if (s1 == null)
                return false;
            if (s2 == null)
                return false;
            if (s3 == null)
                return false;
            if (s1 == "")
                return false;
            if (s2 == "")
                return false;
            if (s3 == "")
                return false;
            return true;
        }

        public bool wheSave(Folder mf1, Folder mf2, String s1, String s2, String s3)
        {
            if (mf2 == null)
                return false;
            if (wheRename(mf1, s1, s2, s3) == false)
                return false;
            if (mf1.getLength() != mf2.getLength())
                return false;
            return true;
              
        }
    }
}
