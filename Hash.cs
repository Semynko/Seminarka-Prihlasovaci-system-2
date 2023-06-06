using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoskola
{
    class Hash
    {
        public string PokusOHash(string heslo)
        {
            string hashovaci = "";

            for (int j = 0; j < heslo.Length; j++)
            {
                if (heslo[j] == 'a')
                {
                    hashovaci += "11";
                }
                if (heslo[j] == 'b')
                {
                    hashovaci += "12";
                }
                if (heslo[j] == 'c')
                {
                    hashovaci += "13";
                }
                if (heslo[j] == 'd')
                {
                    hashovaci += "14";
                }
                if (heslo[j] == 'e')
                {
                    hashovaci += "15";
                }
                if (heslo[j] == 'f')
                {
                    hashovaci += "01";
                }
                if (heslo[j] == 'g')
                {
                    hashovaci += "16";
                }
                if (heslo[j] == 'h')
                {
                    hashovaci += "17";
                }
                if (heslo[j] == 'i')
                {
                    hashovaci += "02";
                }
                if (heslo[j] == 'j')
                {
                    hashovaci += "03";
                }
                if (heslo[j] == 'k' )
                {
                    hashovaci += "08";
                }
                if (heslo[j] == 'l' )
                {
                    hashovaci += "09";
                }
                if (heslo[j] == 'm')
                {
                    hashovaci += "21";
                }
                if (heslo[j] == 'n' )
                {
                    hashovaci += "22";
                }
                if (heslo[j] == 'o')
                {
                    hashovaci += "74";
                }
                if (heslo[j] == 'p' )
                {
                    hashovaci += "69";
                }
                if (heslo[j] == 'q')
                {
                    hashovaci += "33";
                }
                if (heslo[j] == 'r')
                {
                    hashovaci += "44";
                }
                if (heslo[j] == 's' )
                {
                    hashovaci += "54";
                }
                if (heslo[j] == 't')
                {
                    hashovaci += "55";
                }
                if (heslo[j] == 'u' )
                {
                    hashovaci += "88";
                }
                if (heslo[j] == 'v')
                {
                    hashovaci += "78";
                }
                if (heslo[j] == 'w')
                {
                    hashovaci += "49";
                }
                if (heslo[j] == 'x' )
                {
                    hashovaci += "99";
                }
                if (heslo[j] == 'y' )
                {
                    hashovaci += "77";
                }
                if (heslo[j] == 'z')
                {
                    hashovaci += "70";
                }

                if (heslo[j] == '1')
                {
                    hashovaci += "34";
                }
                if (heslo[j] == '2')
                {
                    hashovaci += "85";
                }
                if (heslo[j] == '3')
                {
                    hashovaci += "48";
                }
                if (heslo[j] == '4')
                {
                    hashovaci += "47";
                }
                if (heslo[j] == '5')
                {
                    hashovaci += "67";
                }
                if (heslo[j] == '6')
                {
                    hashovaci += "00";
                }
                if (heslo[j] == '7')
                {
                    hashovaci += "97";
                }
                if (heslo[j] == '8')
                {
                    hashovaci += "96";
                }
                if (heslo[j] == '9')
                {
                    hashovaci += "71";
                }
                if (heslo[j] == '0')
                {
                    hashovaci += "43";
                }

                if(heslo[j] == 'A')
                {
                    hashovaci += "101";
                }
                if (heslo[j] == 'B')
                {
                    hashovaci += "121";
                }
                if (heslo[j] == 'C')
                {
                    hashovaci += "131";
                }
                if (heslo[j] == 'D')
                {
                    hashovaci += "141";
                }
                if (heslo[j] == 'E')
                {
                    hashovaci += "151";
                }
                if (heslo[j] == 'F')
                {
                    hashovaci += "011";
                }
                if (heslo[j] == 'G')
                {
                    hashovaci += "168";
                }
                if (heslo[j] == 'H')
                {
                    hashovaci += "177";
                }
                if (heslo[j] == 'I')
                {
                    hashovaci += "082";
                }
                if (heslo[j] == 'J')
                {
                    hashovaci += "303";
                }
                if (heslo[j] == 'K')
                {
                    hashovaci += "008";
                }
                if (heslo[j] == 'L')
                {
                    hashovaci += "019";
                }
                if (heslo[j] == 'M')
                {
                    hashovaci += "215";
                }
                if (heslo[j] == 'N')
                {
                    hashovaci += "212";
                }
                if (heslo[j] == 'O')
                {
                    hashovaci += "074";
                }
                if (heslo[j] == 'P')
                {
                    hashovaci += "569";
                }
                if (heslo[j] == 'Q')
                {
                    hashovaci += "323";
                }
                if (heslo[j] == 'R')
                {
                    hashovaci += "188";
                }
                if (heslo[j] == 'S')
                {
                    hashovaci += "541";
                }
                if (heslo[j] == 'T')
                {
                    hashovaci += "551";
                }
                if (heslo[j] == 'U')
                {
                    hashovaci += "881";
                }
                if (heslo[j] == 'V')
                {
                    hashovaci += "781";
                }
                if (heslo[j] == 'W')
                {
                    hashovaci += "491";
                }
                if (heslo[j] == 'X')
                {
                    hashovaci += "991";
                }
                if (heslo[j] == 'Y')
                {
                    hashovaci += "771";
                }
                if (heslo[j] == 'Z')
                {
                    hashovaci += "701";
                }

            }
            //gitpokus //h
            heslo = hashovaci;
            return heslo;
            //jj
        }
    }
}

