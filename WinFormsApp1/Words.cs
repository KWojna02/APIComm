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
        public required string Word { get; set; }
        public required int Score { get; set; }
        public override string ToString()
        {
            return $"Word: {Word},\tScore: {Score}";
        }
    }
}
