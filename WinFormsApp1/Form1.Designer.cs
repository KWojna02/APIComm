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
            buttonSort = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage4 = new TabPage();
            textBoxStartsWith = new TextBox();
            checkBoxStartsWith = new CheckBox();
            textBoxLowerThan = new TextBox();
            checkBoxLowerThan = new CheckBox();
            buttonFilter = new Button();
            textBoxHigherThan = new TextBox();
            checkBoxHigherThan = new CheckBox();
            buttonDelete = new Button();
            buttonClear = new Button();
            labelStats = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Cursor = Cursors.Hand;
            buttonDownload.Location = new Point(262, 42);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += ButtonDownload_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(489, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter the word";
            label1.Click += Label1_Click;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(262, 6);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(94, 27);
            textBoxWord.TabIndex = 5;
            textBoxWord.TextChanged += TextBoxWord_TextChanged;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(262, 39);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(94, 27);
            textBoxScore.TabIndex = 6;
            textBoxScore.TextChanged += TextBoxScore_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Location = new Point(262, 72);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(22, 253);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(370, 249);
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
            tabPage1.Size = new Size(362, 216);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Download synonyms";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += TabPage1_Click;
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
            tabPage2.Size = new Size(362, 216);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            tabPage2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 8);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter the word";
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
            tabPage3.Size = new Size(362, 216);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sort";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            buttonSort.Cursor = Cursors.Hand;
            buttonSort.Location = new Point(6, 122);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(94, 29);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += ButtonSort_Click;
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
            radioButton3.CheckedChanged += RadioButton3_CheckedChanged;
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
            // tabPage4
            // 
            tabPage4.Controls.Add(labelStats);
            tabPage4.Controls.Add(textBoxStartsWith);
            tabPage4.Controls.Add(checkBoxStartsWith);
            tabPage4.Controls.Add(textBoxLowerThan);
            tabPage4.Controls.Add(checkBoxLowerThan);
            tabPage4.Controls.Add(buttonFilter);
            tabPage4.Controls.Add(textBoxHigherThan);
            tabPage4.Controls.Add(checkBoxHigherThan);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(362, 216);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Filter";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxStartsWith
            // 
            textBoxStartsWith.Location = new Point(217, 69);
            textBoxStartsWith.MaxLength = 1;
            textBoxStartsWith.Name = "textBoxStartsWith";
            textBoxStartsWith.Size = new Size(25, 27);
            textBoxStartsWith.TabIndex = 6;
            textBoxStartsWith.TextChanged += TextBoxStartsWith_TextChanged;
            // 
            // checkBoxStartsWith
            // 
            checkBoxStartsWith.AutoSize = true;
            checkBoxStartsWith.Location = new Point(6, 69);
            checkBoxStartsWith.Name = "checkBoxStartsWith";
            checkBoxStartsWith.Size = new Size(205, 24);
            checkBoxStartsWith.TabIndex = 5;
            checkBoxStartsWith.Text = "Word - starting with letter:";
            checkBoxStartsWith.UseVisualStyleBackColor = true;
            checkBoxStartsWith.CheckedChanged += CheckBoxStartsWith_CheckedChanged;
            // 
            // textBoxLowerThan
            // 
            textBoxLowerThan.Location = new Point(171, 36);
            textBoxLowerThan.Name = "textBoxLowerThan";
            textBoxLowerThan.Size = new Size(53, 27);
            textBoxLowerThan.TabIndex = 4;
            textBoxLowerThan.TextChanged += TextBoxLowerThan_TextChanged;
            // 
            // checkBoxLowerThan
            // 
            checkBoxLowerThan.AutoSize = true;
            checkBoxLowerThan.Location = new Point(6, 38);
            checkBoxLowerThan.Name = "checkBoxLowerThan";
            checkBoxLowerThan.Size = new Size(155, 24);
            checkBoxLowerThan.TabIndex = 3;
            checkBoxLowerThan.Text = "Score - lower than:";
            checkBoxLowerThan.UseVisualStyleBackColor = true;
            checkBoxLowerThan.CheckedChanged += CheckBoxLowerThan_CheckedChanged;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(295, 181);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(52, 29);
            buttonFilter.TabIndex = 2;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += ButtonFilter_Click;
            // 
            // textBoxHigherThan
            // 
            textBoxHigherThan.Location = new Point(171, 6);
            textBoxHigherThan.Name = "textBoxHigherThan";
            textBoxHigherThan.Size = new Size(53, 27);
            textBoxHigherThan.TabIndex = 1;
            textBoxHigherThan.TextChanged += TextBoxHigherThan_TextChanged;
            // 
            // checkBoxHigherThan
            // 
            checkBoxHigherThan.AutoSize = true;
            checkBoxHigherThan.Location = new Point(6, 6);
            checkBoxHigherThan.Name = "checkBoxHigherThan";
            checkBoxHigherThan.Size = new Size(160, 24);
            checkBoxHigherThan.TabIndex = 0;
            checkBoxHigherThan.Text = "Score - higher than:";
            checkBoxHigherThan.UseVisualStyleBackColor = true;
            checkBoxHigherThan.CheckedChanged += CheckBoxHigherThan_CheckedChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Location = new Point(398, 282);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 28);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Red;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.Location = new Point(398, 316);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(113, 28);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ButtonClear_Click;
            // 
            // label4
            // 
            labelStats.AutoSize = true;
            labelStats.Location = new Point(18, 164);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(50, 20);
            labelStats.TabIndex = 7;
            labelStats.Text = $"Number of filtered synonyms:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 514);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(tabControl1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Synonyms";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private Button buttonDelete;
        private Button buttonClear;
        private TabPage tabPage4;
        private TextBox textBoxHigherThan;
        private CheckBox checkBoxHigherThan;
        private Button buttonFilter;
        private CheckBox checkBoxLowerThan;
        private TextBox textBoxLowerThan;
        private TextBox textBoxStartsWith;
        private CheckBox checkBoxStartsWith;
        private Label labelStats;
    }
}
