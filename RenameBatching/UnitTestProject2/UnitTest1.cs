using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RenameBatching;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFile()
        {
              var myfile = (MyFile)new MyFile("C:\\test\\abc2.c");
              Assert.AreEqual(myfile.getFileName(), "C:\\test\\abc2.c");
              Assert.AreEqual(myfile.getpath(), "C:\\test");
              Assert.AreEqual(myfile.getPreName(),"abc2");
              Assert.AreEqual(myfile.getExpandName(), "c");
         //   myfile.getExpandName().Equals("c");
       //         ((this.test("C:\\test\\a.c").getFileName) == "C:\\test\\a.c");

        }
        [TestMethod]
        public void TestFolder()
        { 
            String[] s = {"C:\\test\\abc2.c","C:\\test\\abc3.c","C:\\test\\we2.png"};
            var folder = new Folder(s);
         //   Assert.AreEqual();
            Assert.AreEqual(folder.getExpName(),"c");
            Assert.AreEqual(folder.getFirstFileName(), "abc2");
            Assert.AreEqual(folder.getLength(),3);
            Assert.AreEqual(folder.getName(), "C:\\test\\abc2.c");
            Assert.AreEqual(folder.getpath(),"C:\\test");

        }

        [TestMethod]
        public void TestFuction()
        {
            
            MainFunction mainf = new MainFunction();
            String[] s1 = { "C:\\test\\abc2.c", "C:\\test\\abc3.c", "C:\\test\\we2.png" };
            String[] s2 = { "C:\\test\\1.c", "C:\\test\\2c3.c", "C:\\test\\true2.c" };
            Folder folder1 = new Folder(s1);
            Folder folder2 = new Folder(s2);
            
            mainf.reName(folder1, folder2);
            //   Assert.AreEqual();
            Assert.AreEqual(folder2.myfile[0].getFileName(), "C:\\test\\1.c");
            Assert.AreEqual(folder2.myfile[1].getFileName(), "C:\\test\\2c3.c");
            Assert.AreEqual(folder2.myfile[2].getFileName(), "C:\\test\\true2.c");

            //Assert.AreEqual(folder2.myfile[0].getExpandName(), "C:\\test\\abc2.c");
            //Assert.AreEqual(folder2.myfile[1].getExpandName(), "C:\\test\\abc3.c");
            //Assert.AreEqual(folder2.myfile[2].getExpandName(), "C:\\test\\we2.png");

            //Assert.AreEqual(folder2.myfile[0].getPreName()., "C:\\test\\abc2.c");
            //Assert.AreEqual(folder2.myfile[1].getPreName(), "C:\\test\\abc3.c");
            //Assert.AreEqual(folder2.myfile[2].getPreName(), "C:\\test\\we2.png");

        }
    
    


    }
}
