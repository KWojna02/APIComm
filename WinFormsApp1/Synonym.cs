using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Synonym
    {
        public int Id { get; set; }
        public required string word { get; set; }
        public required int score { get; set; }
        public override string ToString()
        {
            return $"Word: {word},\tScore: {score}";
        }
    }
}
