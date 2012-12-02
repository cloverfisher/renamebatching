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
            this.FolderButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.part1 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.expend1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AutoArrange = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(60, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 354);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(460, 66);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(37, 21);
            this.numBox.TabIndex = 2;
            // 
            // ExtensionBox
            // 
            this.ExtensionBox.Location = new System.Drawing.Point(517, 66);
            this.ExtensionBox.Name = "ExtensionBox";
            this.ExtensionBox.Size = new System.Drawing.Size(52, 21);
            this.ExtensionBox.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(600, 89);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(284, 354);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(38, 12);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 23);
            this.FolderButton.TabIndex = 5;
            this.FolderButton.Text = "folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(600, 60);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(745, 60);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // part1
            // 
            this.part1.AutoSize = true;
            this.part1.Location = new System.Drawing.Point(321, 51);
            this.part1.Name = "part1";
            this.part1.Size = new System.Drawing.Size(35, 12);
            this.part1.TabIndex = 8;
            this.part1.Text = "Part1";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(458, 51);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(23, 12);
            this.Num1.TabIndex = 9;
            this.Num1.Text = "Num";
            // 
            // expend1
            // 
            this.expend1.AutoSize = true;
            this.expend1.Location = new System.Drawing.Point(528, 51);
            this.expend1.Name = "expend1";
            this.expend1.Size = new System.Drawing.Size(41, 12);
            this.expend1.TabIndex = 10;
            this.expend1.Text = "Expend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 455);
            this.Controls.Add(this.expend1);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.part1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.FolderButton);
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
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label part1;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label expend1;
    }
}

