using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Palindroom
    {
        public string Inhoud { get; set; }

        public Palindroom(string inhoud)
        {
            Inhoud = inhoud;
        }

        public bool IsPalindroom()
        {
            var omgekeerd = new string(Inhoud.ToArray().Reverse().ToArray());
            return Inhoud == omgekeerd;
        }
        public bool IsPalindroom01() // alternatieve versie
        {
            for (var teller = 0; teller < Inhoud.Length / 2; teller++)
            {
                if (Inhoud[teller] != Inhoud[Inhoud.Length - 1 - teller]) return false;
            }
            return true;
        }
        public bool IsPalindroom02() // alternatieve versie
        {
            return Inhoud == new string(Inhoud.ToCharArray().Reverse().ToArray());
        }
    }
}
