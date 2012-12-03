namespace RenameBatching
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.ExtensionBox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.part1 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.textBoxExpand = new System.Windows.Forms.Label();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPostfix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AutoArrange = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 115);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(458, 48);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(37, 21);
            this.numBox.TabIndex = 2;
            this.numBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBox_KeyPress);
            // 
            // ExtensionBox
            // 
            this.ExtensionBox.Location = new System.Drawing.Point(530, 48);
            this.ExtensionBox.Name = "ExtensionBox";
            this.ExtensionBox.Size = new System.Drawing.Size(52, 21);
            this.ExtensionBox.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(58, 290);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(804, 115);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(70, 12);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 5;
            this.buttonFolder.Text = "folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(597, 12);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(695, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // part1
            // 
            this.part1.AutoSize = true;
            this.part1.Location = new System.Drawing.Point(197, 51);
            this.part1.Name = "part1";
            this.part1.Size = new System.Drawing.Size(35, 12);
            this.part1.TabIndex = 8;
            this.part1.Text = "Part1";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(429, 51);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(23, 12);
            this.Num1.TabIndex = 9;
            this.Num1.Text = "Num";
            // 
            // textBoxExpand
            // 
            this.textBoxExpand.AutoSize = true;
            this.textBoxExpand.Location = new System.Drawing.Point(528, 23);
            this.textBoxExpand.Name = "textBoxExpand";
            this.textBoxExpand.Size = new System.Drawing.Size(41, 12);
            this.textBoxExpand.TabIndex = 10;
            this.textBoxExpand.Text = "Expand";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(787, 12);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 11;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(247, 75);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(121, 21);
            this.textBoxPrefix.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Prefix";
            // 
            // textBoxPostfix
            // 
            this.textBoxPostfix.Location = new System.Drawing.Point(247, 102);
            this.textBoxPostfix.Name = "textBoxPostfix";
            this.textBoxPostfix.Size = new System.Drawing.Size(121, 21);
            this.textBoxPostfix.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Postfix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPostfix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.textBoxExpand);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.part1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.ExtensionBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.TextBox ExtensionBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label part1;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label textBoxExpand;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPostfix;
        private System.Windows.Forms.Label label2;
    }
}

