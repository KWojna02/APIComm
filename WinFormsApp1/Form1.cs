using System.Text.Json;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private WordsDictionary Dict;
        public Form1()
        {
            InitializeComponent();
            Dict = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string word = textBox1.Text;
            if (word != "")
            {
                Dict.Synonyms.RemoveRange(Dict.Synonyms);
                Dict.SaveChanges();
                string call = $"https://api.datamuse.com/words?rel_syn={word}";
                //string response = await client.GetStringAsync(call);
                //List<Synonym> Synonyms = JsonSerializer.Deserialize<List<Synonym>>(response);
                //foreach (var Synonym in Synonyms) listBox1.Items.Add(Synonym.ToString());
            }
            else return;



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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dict.Synonyms.Add(new Synonym() { Word = textBoxWord.Text, Score = int.Parse(textBoxScore.Text) });
            Dict.SaveChanges();
            listBox1.DataSource = Dict.Synonyms.ToList<Synonym>();

        }        

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxScore_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
