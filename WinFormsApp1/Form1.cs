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
            }
            else
            {
                MessageBox.Show($"Dozwolone sπ tylko S£OWA (bez cyfr) w jÍzyku angielskim.");
                buttonDownload.Enabled = true;
                return;
            }

            buttonDownload.Enabled = true;




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string word = textBox1.Text.ToLower().Trim();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newWord = textBoxWord.Text.ToLower().Trim();
            int newScore = 0;
            bool exists = false;
            foreach(Synonym existingSynonym in Dict.Synonyms)
            {
                if (existingSynonym.word == newWord) { exists = true; break; }
            }
            if(exists)
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
    }
}
