using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private WordsDictionary Dict;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new();
            Dict = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
            if (Dict.Synonyms.ToList<Synonym>().Count == 0) { buttonClear.Enabled = false; buttonDelete.Enabled = false; }
            labelStats.Visible = false;
        }

        private static bool IsAllLetters(string input)
        {
            foreach(char c in input)
            {
                if(!char.IsLetter(c)) return false;
            }
            return true;
        }

        private async void ButtonDownload_Click(object sender, EventArgs e)
        {
            buttonDownload.Enabled = false;

            string newWord = textBox1.Text.ToLower().Trim();
            if (IsAllLetters(newWord))

            {
                Dict.Synonyms.RemoveRange(Dict.Synonyms);
                Dict.SaveChanges();
                string call = $"https://api.datamuse.com/words?rel_syn={newWord}";
                string response = await client.GetStringAsync(call);
                List<Synonym> Synonyms = JsonSerializer.Deserialize<List<Synonym>>(response);
                foreach (Synonym Synonym in Synonyms)
                {
                    Dict.Synonyms.Add(new() { word = Synonym.word.ToLower(), score = Synonym.score });
                    Dict.SaveChanges();
                    listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
                }
                
            }
            else
            {
                MessageBox.Show($"Only WORDS (no digits) are accepted.");
                buttonDownload.Enabled = true;
                return;
            }

            buttonDownload.Enabled = true;
            buttonClear.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string newWord = textBoxWord.Text.ToLower().Trim();
            int newScore = 0;
            bool exists = false;
            foreach (Synonym existingSynonym in Dict.Synonyms)
            {
                if (existingSynonym.word == newWord) { exists = true; break; }
            }
            if (exists)
            {
                MessageBox.Show($"The word {newWord} already exists in database.");
                return;
            }
            else if (!int.TryParse(textBoxScore.Text.Trim(), out newScore) || int.Parse(textBoxScore.Text) < 0)
            {
                MessageBox.Show("Fill the gaps properly.");
                return;
            }

            Synonym syn = new() { word = newWord, score = newScore };
            Dict.Synonyms.Add(syn);
            Dict.SaveChanges();
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();

            buttonClear.Enabled = true;
            buttonDelete.Enabled = true;

        }

        private void TextBoxWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxScore_TextChanged(object sender, EventArgs e)
        {

            string score = textBoxScore.Text.Trim();



            if (!int.TryParse(score, out int score_int) || int.Parse(score) < 0) textBoxScore.BackColor = Color.Red;
            else textBoxScore.BackColor = Color.Green;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked
                && !radioButton2.Checked
                && !radioButton3.Checked
                && !radioButton4.Checked) return;
            else if (radioButton1.Checked)
            {
                listBox1.DataSource = Dict.Synonyms.OrderBy(x => x.word).ToList<Synonym>();
            }
            else if (radioButton2.Checked)
            {
                listBox1.DataSource = Dict.Synonyms.OrderBy(x => x.word).Reverse().ToList<Synonym>();
            }
            else if (radioButton3.Checked)
            {
                listBox1.DataSource = Dict.Synonyms.OrderBy(x => x.score).ToList<Synonym>();
            }
            else if (radioButton4.Checked)
            {
                listBox1.DataSource = Dict.Synonyms.OrderBy(x => x.score).Reverse().ToList<Synonym>();
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            Synonym synonym = listBox1.SelectedItem as Synonym;
            Dict.Synonyms.Remove(synonym);
            Dict.SaveChanges();
            MessageBox.Show($"Word {synonym.word} with score {synonym.score} has been deleted.");
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
            if (Dict.Synonyms.ToList<Synonym>().Count == 0) { buttonDelete.Enabled = false; buttonClear.Enabled = false; }

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Dict.Synonyms.RemoveRange(Dict.Synonyms);
            Dict.SaveChanges();
            MessageBox.Show("The database has been cleared successfully.");
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
            buttonDelete.Enabled = false;
            buttonClear.Enabled = false;

        }

        

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxHigherThan.BackColor == Color.Red
                || textBoxLowerThan.BackColor == Color.Red
                || textBoxStartsWith.BackColor == Color.Red)
            {
                MessageBox.Show("Fill the gaps with proper values.");
                return;
            }
            else
            {
                bool filters = true;
                if (checkBoxHigherThan.Checked && checkBoxLowerThan.Checked && checkBoxStartsWith.Checked)
                {
                    int value1 = int.Parse(textBoxHigherThan.Text.Trim()); //checkbox n.1
                    int value2 = int.Parse(textBoxLowerThan.Text.Trim()); //checkbox n.2
                    char letter = textBoxStartsWith.Text.Trim().FirstOrDefault(); //checkbox n.3
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.score > value1
                            && s.score < value2
                            && s.word.FirstOrDefault() == letter)
                        .ToList<Synonym>();

                }
                else if (checkBoxHigherThan.Checked && checkBoxStartsWith.Checked)
                {
                    int value = int.Parse(textBoxHigherThan.Text.Trim());
                    char letter = textBoxStartsWith.Text.Trim().FirstOrDefault();
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.score > value
                            && s.word.FirstOrDefault() == letter)
                        .ToList<Synonym>();
                }
                else if (checkBoxLowerThan.Checked && checkBoxStartsWith.Checked)
                {
                    int value = int.Parse(textBoxLowerThan.Text.Trim());
                    char letter = textBoxStartsWith.Text.Trim().FirstOrDefault();
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.score < value
                            && s.word.FirstOrDefault() == letter)
                        .ToList<Synonym>();
                }
                else if(checkBoxLowerThan.Checked && checkBoxHigherThan.Checked)
                {
                    int value1 = int.Parse(textBoxHigherThan.Text.Trim()); //checkbox n.1
                    int value2 = int.Parse(textBoxLowerThan.Text.Trim()); //checkbox n.2
                    if(value1 == value2)
                    {
                        listBox1.DataSource = Dict.Synonyms
                            .Where(s => s.score == value1)
                            .ToList<Synonym>();
                    }
                    else
                    {
                        listBox1.DataSource = Dict.Synonyms
                            .Where(s => s.score > value1 
                                && s.score < value2)
                            .ToList<Synonym>();
                    }
                }
                else if (checkBoxHigherThan.Checked)
                {
                    int value = int.Parse(textBoxHigherThan.Text.Trim());
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.score > value)
                        .ToList<Synonym>();
                }
                else if (checkBoxLowerThan.Checked)
                {
                    int value = int.Parse(textBoxLowerThan.Text.Trim());
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.score < value)
                        .ToList<Synonym>();
                }
                else if (checkBoxStartsWith.Checked)
                {
                    char letter = textBoxStartsWith.Text.Trim().FirstOrDefault();
                    listBox1.DataSource = Dict.Synonyms
                        .Where(s => s.word.FirstOrDefault() == letter)
                        .ToList<Synonym>();
                }
                else
                {
                    listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
                    filters = false;
                }
                if (filters)
                {
                    int count = listBox1.Items.Count;
                    labelStats.Visible = true;
                    labelStats.Text = $"Number of filtered synonyms: {count}";
                }
                else labelStats.Visible = false;
                
            }
        }

        private void CheckBoxHigherThan_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxHigherThan_TextChanged(sender, e);
        }
        private void CheckBoxLowerThan_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxLowerThan_TextChanged(sender, e);
        }

        private void CheckBoxStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxStartsWith_TextChanged(sender, e);
        }

        private void TextBoxHigherThan_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxHigherThan.Checked)
            {
                string score1 = textBoxHigherThan.Text.Trim();
                string score2 = textBoxLowerThan.Text.Trim();

                bool parsed = false;

                if (!int.TryParse(score1, out int score1_int)
                   || int.Parse(score1) < 0
                   ) textBoxHigherThan.BackColor = Color.Red;
                else { textBoxHigherThan.BackColor = Color.Green; parsed = true; }

                if(parsed && checkBoxLowerThan.Checked
                    && int.TryParse(score2, out int score2_int))
                {
                    if(int.Parse(score1) > int.Parse(score2))
                    {
                        textBoxHigherThan.BackColor = Color.Red;
                        textBoxLowerThan.BackColor = Color.Red;
                    }
                    else if(int.Parse(score1) <= int.Parse(score2))
                    {
                        textBoxHigherThan.BackColor = Color.Green;
                        textBoxLowerThan.BackColor = Color.Green;
                    }
                    
                }
            }
            else textBoxHigherThan.BackColor = SystemColors.Window;
        }

        private void TextBoxLowerThan_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxLowerThan.Checked)
            {
                string score = textBoxLowerThan.Text.Trim();
                bool parsed = false;

                if (!int.TryParse(score, out int score_int)
                    || int.Parse(score) < 0
                     ) textBoxLowerThan.BackColor = Color.Red;

                else { textBoxLowerThan.BackColor = Color.Green; parsed = true; }
                if (parsed && checkBoxHigherThan.Checked)
                {
                    if(int.Parse(score) < int.Parse(textBoxHigherThan.Text.Trim()))
                    {
                        textBoxHigherThan.BackColor = Color.Red;
                        textBoxLowerThan.BackColor = Color.Red;
                    }
                    else if(int.Parse(score) >= int.Parse(textBoxHigherThan.Text.Trim()))
                    {
                        textBoxHigherThan.BackColor = Color.Green;
                        textBoxLowerThan.BackColor = Color.Green;
                    }
                }
            }
            else textBoxLowerThan.BackColor = SystemColors.Window;
        }

        private void TextBoxStartsWith_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxStartsWith.Checked)
            {
                char input = textBoxStartsWith.Text.Trim().ToLower().FirstOrDefault();
                textBoxStartsWith.BackColor = char.IsLetter(input) ? Color.Green : Color.Red;
            }
            else textBoxStartsWith.BackColor = SystemColors.Window;

        }       

       
    }
}
