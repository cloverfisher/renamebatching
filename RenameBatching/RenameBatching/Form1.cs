using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameBatching
{
    public partial class Form1 : Form
    {
        MainFunction mainfunction = new MainFunction();

        string tempstring;
        Folder folder1;
        Folder folder2;

        public Form1()
        {
            InitializeComponent();
            textBoxExpand.Text = "";
            textBox1.Text = "";
            textBoxPostfix.Text = "";
            textBoxPrefix.Text = "";
            numBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            String[] line;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jepg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;

            tempstring = numBox.Text;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        line = openFileDialog1.FileNames;
  //                      MyFile file = new MyFile(line[0]);
                        folder1 = new Folder(line);

    //                    listView1.Items.Clear();
    //                    ListViewItem alistViewItem = new ListViewItem(line);
   //                     listView1.Items.Add(alistViewItem);
                        listview(folder1,listView1);
                        textBox1.Text = folder1.getFirstFileName();
                        ExtensionBox.Text = folder1.getExpName();
                        numBox.Text = "1";
                        myStream.Close();
                 //       openFileDialog1.
                //        Folder changedfold = new Folder(String Path, String name1,int num, String expendNum);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mainfunction.wheSave(folder1, folder2, numBox.Text, textBox1.Text, ExtensionBox.Text))
            {
                mainfunction.reName(folder1, folder2);
                mainfunction.openFolder(folder1.getpath());
                
            }

        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (mainfunction.wheSave(folder1, folder2, numBox.Text, textBox1.Text, ExtensionBox.Text))
            {
                mainfunction.reName(folder2, folder1);
            //    mainfunction.openFolder(folder1.getpath());
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (mainfunction.wheRename(folder1, numBox.Text, textBox1.Text, ExtensionBox.Text))
            {
                folder2 = mainfunction.creatNewFolder(folder1, numBox.Text, textBox1.Text, ExtensionBox.Text,textBoxPrefix.Text,textBoxPostfix.Text);
                listview(folder2, listView2);         
            }
     //       File.Move("D:\\test\\a.txt", "D:\\test\\a2.txt");

            
        }


        private void listview(Folder afolder, ListView alistview)
        {

            alistview.Clear();
            listView1.GridLines = true;//显示网格线
            alistview.FullRowSelect = true;
      //      alistview.View = View.Details;

         //   alistview.Items.Add("file");
            for (int i = 0; i < afolder.getLength(); i++)
            {
                alistview.Items.Add(afolder.myfile[i].getPreName() + "." + afolder.myfile[i].getExpandName());
        //        alistview.Items[i].SubItems.Add("." + afolder.myfile[i].getExpandName());
             //   ListViewItem alistViewItem = new ListViewItem(afolder.myfile[i].getPreName());
                //  alistViewItem.SubItems.Add();
             //   alistview.Columns.Add(afolder.myfile[i].getPreName(), 100);
            }
            //      alistview.Items.Add(alistViewItem);
            //  return alistview;
        }



        private void numBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)  
        {  
            if(e.KeyChar!='\b')//这是允许输入退格键  
            {  
                if((e.KeyChar<'0')||(e.KeyChar>'9'))//这是允许输入0-9数字  
                {  
                 e.Handled = true;  
                }  
            }  
        }







        //private void numBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
