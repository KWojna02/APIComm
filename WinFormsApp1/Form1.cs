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
            if (Dict.Synonyms.ToList<Synonym>().Count() == 0) { buttonClear.Enabled = false; buttonDelete.Enabled = false; }
            labelStats.Visible = false;
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            buttonDownload.Enabled = false;

            string newWord = textBox1.Text.ToLower().Trim();
            if (Regex.IsMatch(newWord, @"^[a-zA-ZπÊÍ≥ÒÛúüø•∆ £—”åèØ]+$"))

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
                buttonAdd.Visible = true;
            }
            else
            {
                MessageBox.Show($"Dozwolone sπ tylko S£OWA (bez cyfr) w jÍzyku angielskim.");
                buttonDownload.Enabled = true;
                return;
            }

            buttonDownload.Enabled = true;
            buttonClear.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Slowo {newWord} juz istnieje w bazie danych.");
                return;
            }
            else if (!int.TryParse(textBoxScore.Text.Trim(), out newScore) || int.Parse(textBoxScore.Text) < 0)
            {
                MessageBox.Show("Zle wprowadzony wynik");
                return;
            }

            Synonym syn = new() { word = newWord, score = newScore };
            Dict.Synonyms.Add(syn);
            Dict.SaveChanges();
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();

            buttonClear.Enabled = true;
            buttonDelete.Visible = true;

        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxScore_TextChanged(object sender, EventArgs e)
        {

            string score = textBoxScore.Text.Trim();



            if (!int.TryParse(score, out int score_int) || int.Parse(score) < 0) textBoxScore.BackColor = Color.Red;
            else textBoxScore.BackColor = Color.Green;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            Synonym synonym = listBox1.SelectedItem as Synonym;
            Dict.Synonyms.Remove(synonym);
            Dict.SaveChanges();
            MessageBox.Show($"Word {synonym.word} with score {synonym.score} has been deleted.");
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
            if (Dict.Synonyms.ToList<Synonym>().Count == 0) { buttonDelete.Visible = false; buttonClear.Enabled = false; }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Dict.Synonyms.RemoveRange(Dict.Synonyms);
            Dict.SaveChanges();
            MessageBox.Show("The database has been cleared successfully.");
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxHigherThan.BackColor == Color.Red
                || textBoxLowerThan.BackColor == Color.Red
                || textBoxStartsWith.BackColor == Color.Red)
            {
                MessageBox.Show("Fill the filter fields with proper values.");
                return;
            }
            else
            {
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
            }
        }

        private void checkBoxHigherThan_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHigherThan_TextChanged(sender, e);
        }
        private void checkBoxLowerThan_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLowerThan_TextChanged(sender, e);
        }

        private void checkBoxStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            textBoxStartsWith_TextChanged(sender, e);
        }

        private void textBoxHigherThan_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxHigherThan.Checked)
            {
                string score = textBoxHigherThan.Text.Trim();

                if (!int.TryParse(score, out int score_int)
                   || int.Parse(score) < 0
                   ) textBoxHigherThan.BackColor = Color.Red;
                else if (checkBoxLowerThan.Checked
                    && int.Parse(score) > int.Parse(textBoxLowerThan.Text.Trim()))
                {
                    textBoxHigherThan.BackColor = Color.Red;
                    textBoxLowerThan.BackColor = Color.Red;
                }


                else textBoxHigherThan.BackColor = Color.Green;
            }
            else textBoxHigherThan.BackColor = SystemColors.Window;
        }

        private void textBoxLowerThan_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxLowerThan.Checked)
            {
                string score = textBoxLowerThan.Text.Trim();

                if (!int.TryParse(score, out int score_int)
                    || int.Parse(score) < 0
                     ) textBoxLowerThan.BackColor = Color.Red;

                else textBoxLowerThan.BackColor = Color.Green;
                if (checkBoxHigherThan.Checked
                    && int.Parse(score) < int.Parse(textBoxHigherThan.Text.Trim()))
                {
                    textBoxHigherThan.BackColor = Color.Red;
                    textBoxLowerThan.BackColor = Color.Red;
                }
            }
            else textBoxHigherThan.BackColor = SystemColors.Window;
        }

        private void textBoxStartsWith_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxStartsWith.Checked)
            {
                char input = textBoxStartsWith.Text.Trim().ToLower().First();
                textBoxStartsWith.BackColor = char.IsLetter(input) ? Color.Green : Color.Red;
            }
            else textBoxHigherThan.BackColor = SystemColors.Window;

        }       

        private void calculateStats(object sender, EventArgs e)
        {

        }
    }
}
