namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDownload = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBoxWord = new TextBox();
            textBoxScore = new TextBox();
            buttonAdd = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            buttonSort = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(489, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;            
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(22, 253);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(302, 155);
            tabControl1.TabIndex = 9;
                // 
                // tabPage1
                // 
                tabPage1.Controls.Add(label1);
                tabPage1.Controls.Add(textBox1);
                tabPage1.Controls.Add(buttonDownload);
                tabPage1.Location = new Point(4, 29);
                tabPage1.Name = "tabPage1";
                tabPage1.Padding = new Padding(3);
                tabPage1.Size = new Size(294, 113);
                tabPage1.TabIndex = 0;
                tabPage1.Text = "Download synonyms";
                tabPage1.UseVisualStyleBackColor = true;
                tabPage1.Click += tabPage1_Click;
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Location = new Point(6, 9);
                    label1.Name = "label1";
                    label1.Size = new Size(106, 20);
                    label1.TabIndex = 3;
                    label1.Text = "Enter the word";
                    label1.Click += label1_Click;
                    // 
                    // textBox1
                    // 
                    textBox1.Location = new Point(163, 6);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new Size(125, 27);
                    textBox1.TabIndex = 2;
                    textBox1.TextChanged += textBox1_TextChanged;
                    // 
                    // buttonDownload
                    // 
                    buttonDownload.Location = new Point(194, 78);
                    buttonDownload.Name = "buttonDownload";
                    buttonDownload.Size = new Size(94, 29);
                    buttonDownload.TabIndex = 0;
                    buttonDownload.Text = "download";
                    buttonDownload.UseVisualStyleBackColor = true;
                    buttonDownload.Click += buttonDownload_Click;
                // 
                // tabPage2
                // 
                tabPage2.Controls.Add(label3);
                tabPage2.Controls.Add(label2);
                tabPage2.Controls.Add(textBoxWord);
                tabPage2.Controls.Add(textBoxScore);
                tabPage2.Controls.Add(buttonAdd);
                tabPage2.Location = new Point(4, 29);
                tabPage2.Name = "tabPage2";
                tabPage2.Padding = new Padding(3);
                tabPage2.Size = new Size(294, 113);
                tabPage2.TabIndex = 1;
                tabPage2.Text = "Add";
                tabPage2.UseVisualStyleBackColor = true;
                    // 
                    // label2
                    // 
                    label2.AutoSize = true;
                    label2.Location = new Point(6, 8);
                    label2.Name = "label2";
                    label2.Size = new Size(106, 20);
                    label2.TabIndex = 7;
                    label2.Text = "Enter the word";
                    // 
                    // textBoxWord
                    // 
                    textBoxWord.Location = new Point(197, 8);
                    textBoxWord.Name = "textBoxWord";
                    textBoxWord.Size = new Size(94, 27);
                    textBoxWord.TabIndex = 5;
                    textBoxWord.TextChanged += textBoxWord_TextChanged;
                    // 
                    // label3
                    // 
                    label3.AutoSize = true;
                    label3.Location = new Point(6, 44);
                    label3.Name = "label3";
                    label3.Size = new Size(156, 20);
                    label3.TabIndex = 8;
                    label3.Text = "Enter this word's score";
                    // 
                    // textBoxScore
                    // 
                    textBoxScore.Location = new Point(197, 41);
                    textBoxScore.Name = "textBoxScore";
                    textBoxScore.Size = new Size(94, 27);
                    textBoxScore.TabIndex = 6;
                    textBoxScore.TextChanged += textBoxScore_TextChanged;
                    // 
                    // buttonAdd
                    // 
                    buttonAdd.Location = new Point(197, 74);
                    buttonAdd.Name = "buttonAdd";
                    buttonAdd.Size = new Size(94, 29);
                    buttonAdd.TabIndex = 4;
                    buttonAdd.Text = "Add";
                    buttonAdd.UseVisualStyleBackColor = true;
                    buttonAdd.Click += buttonAdd_Click;
                // 
                // tabPage3
                // 
                tabPage3.Controls.Add(buttonSort);
                tabPage3.Controls.Add(radioButton4);
                tabPage3.Controls.Add(radioButton3);
                tabPage3.Controls.Add(radioButton2);
                tabPage3.Controls.Add(radioButton1);
                tabPage3.Location = new Point(4, 29);
                tabPage3.Name = "tabPage3";
                tabPage3.Padding = new Padding(3);
                tabPage3.Size = new Size(294, 122);
                tabPage3.TabIndex = 2;
                tabPage3.Text = "Sort";
                tabPage3.UseVisualStyleBackColor = true;
                // 
                // radioButton1
                // 
                radioButton1.AutoSize = true;
                radioButton1.Location = new Point(6, 0);
                radioButton1.Name = "radioButton1";
                radioButton1.Size = new Size(55, 24);
                radioButton1.TabIndex = 0;
                radioButton1.TabStop = true;
                radioButton1.Text = "A-Z";
                radioButton1.UseVisualStyleBackColor = true;
                // 
                // radioButton2
                // 
                radioButton2.AutoSize = true;
                radioButton2.Location = new Point(6, 30);
                radioButton2.Name = "radioButton2";
                radioButton2.Size = new Size(55, 24);
                radioButton2.TabIndex = 1;
                radioButton2.TabStop = true;
                radioButton2.Text = "Z-A";
                radioButton2.UseVisualStyleBackColor = true;
                // 
                // radioButton3
                // 
                radioButton3.AutoSize = true;
                radioButton3.Location = new Point(6, 60);
                radioButton3.Name = "radioButton3";
                radioButton3.Size = new Size(187, 24);
                radioButton3.TabIndex = 2;
                radioButton3.TabStop = true;
                radioButton3.Text = "Score: lowest to highest";
                radioButton3.UseVisualStyleBackColor = true;
                radioButton3.CheckedChanged += radioButton3_CheckedChanged;
                // 
                // radioButton4
                // 
                radioButton4.AutoSize = true;
                radioButton4.Location = new Point(6, 92);
                radioButton4.Name = "radioButton4";
                radioButton4.Size = new Size(187, 24);
                radioButton4.TabIndex = 3;
                radioButton4.TabStop = true;
                radioButton4.Text = "Score: highest to lowest";
                radioButton4.UseVisualStyleBackColor = true;
                // 
                // buttonSort
                // 
                buttonSort.Location = new Point(194, 87);
                buttonSort.Name = "buttonSort";
                buttonSort.Size = new Size(94, 29);
                buttonSort.TabIndex = 4;
                buttonSort.Text = "Sort";
                buttonSort.UseVisualStyleBackColor = true;
                buttonSort.Click += buttonSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 514);
            Controls.Add(tabControl1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "\\";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxWord;
        private TextBox textBoxScore;
        private Button buttonAdd;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private TabPage tabPage3;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button buttonSort;
    }
}
