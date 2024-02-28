using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekeningnummer
    {
        private static readonly Regex regex =
            new Regex("^BE(\\d{2})(\\d{12})$"); 
        private readonly string nummer;
        public Rekeningnummer(string nummer)
        {
            if (!regex.IsMatch(nummer)) 
            {
                throw new ArgumentException();
            }
            var controleString = nummer.Substring(2, 2);
            var rekeningGetal = long.Parse(
                nummer.Substring(4, nummer.Length - 4) + "1114" + controleString);
            var controleGetal = int.Parse(controleString);
            if (controleGetal < 2 || controleGetal > 98)
                throw new ArgumentException("1e of 2e cijfer verkeerd");
            if (rekeningGetal % 97 != 1)
                throw new ArgumentException("Nummer bevat verkeerde cijfers");
            this.nummer = nummer;
        }
        public override string ToString()
        {
            return nummer;
        }
    }
}
