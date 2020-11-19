using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS
{
    [Serializable]
    public class CharacterSheet
    {
        public List<Character> CharacterIndex = new List<Character>();

        public string Test = "";

        public List<Character> GetCharacterIndex
        {
            get { return CharacterIndex; }
        }

        public void ResetCharacterIndex()
        {
            CharacterIndex = new List<Character>();
        }

        //public PrintContent()
        //{

        //}
    }
}
