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
            buttonAdd = new Button();
            textBoxWord = new TextBox();
            textBoxScore = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(334, 409);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "download";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(22, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 412);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter the word";
            label1.Click += label1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(334, 320);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(334, 254);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(94, 27);
            textBoxWord.TabIndex = 5;
            textBoxWord.TextChanged += textBoxWord_TextChanged;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(334, 287);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(94, 27);
            textBoxScore.TabIndex = 6;
            textBoxScore.TextChanged += textBoxScore_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 257);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter the word to add";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 287);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 8;
            label3.Text = "Enter this word's score";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxScore);
            Controls.Add(textBoxWord);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(buttonDownload);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Button buttonAdd;
        private TextBox textBoxWord;
        private TextBox textBoxScore;
        private Label label2;
        private Label label3;
    }
}
