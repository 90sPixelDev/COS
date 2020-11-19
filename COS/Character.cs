using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS
{
    [Serializable]
    public class Character
    {
        public Character()
        {
        }
        public Character(string _charaName)
        {
            charaName = _charaName;
        }

        public string charaName { get; set; }
        public string charaAge { get; set; }
        public string dob { get; set; }

        public string weight { get; set; }
        public string height { get; set; }

        public enum Pronoun
        {
            nonbinary,
            female,
            male
        }

        public Pronoun pronoun;

        public string species { get; set; }
        public string nationality { get; set; }

        public string personality { get; set; }

        public List<string> likes = new List<string>();
        public List<string> dislikes = new List<string>();

        //More to come ->
    }
}
