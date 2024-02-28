using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Isbn
    {
        private static readonly Regex regex = new Regex("^\\d{13}$");
        private readonly long nummer;

        public Isbn(long nummer)
        {
            if (!regex.IsMatch(nummer.ToString()))
            {
                throw new ArgumentException();
            }

            var somEvenCijfers = 0l;
            var somOnevenCijfers = 0l;
            var teVerwerkenCijfers = nummer / 10;

            for (int teller = 0; teller != 6; teller++)
            {
                somEvenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
                somOnevenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
            }

            var controleGetal = somEvenCijfers * 3 + somOnevenCijfers;
            var naastGelegenHoger10Tal = controleGetal - controleGetal % 10 + 10;
            var verschil = naastGelegenHoger10Tal - controleGetal;
            var laatsteCijfer = nummer % 10;

            if (verschil == 10)
            {
                if (laatsteCijfer != 0)
                    throw new ArgumentException();
            }
            else
            {
                if (laatsteCijfer != verschil)
                    throw new ArgumentException();
            }
            this.nummer = nummer;
        }
        public override string ToString()
        {
            return nummer.ToString();
        }
    }
}
