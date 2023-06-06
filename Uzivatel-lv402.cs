using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoskola
{
    internal class Uzivatel
    {
        public string Uzjmeno { get; set; }
        public string Heslo { get; set; }
        public string Potvrditheslo { get; set; }
        public string Emailus { get; set; }
        public int Pocetradkuhes { get; set; }
        public int Pocetradkujmen{ get;set; }
        public int Pocetradkuemail { get; set; }
        public string[] Radhes { get; set; }
        public string[] Radjmen { get; set; }
        public string[] Rademail { get; set; }
        public string Jmen { get; set; }    
        public string Hes { get; set; }
        public string Email { get; set; }

        public Uzivatel(string uzjmeno, string heslo, string potvrditheslo, string emailus, int pocetradkuhes, int pocetradkujmen, int pocetradkuemail, string[] radhes, string[] radjmen, string[] rademail, string jmen, string hes, string email)
        {
            Uzjmeno = uzjmeno;
            Heslo = heslo;
            Potvrditheslo = potvrditheslo;
            Emailus = emailus;
            Pocetradkuhes = pocetradkuhes;
            Pocetradkujmen = pocetradkujmen;
            Pocetradkuemail = pocetradkuemail;
            Radhes = radhes;
            Radjmen = radjmen;
            Rademail = rademail;
            Jmen = jmen;
            Hes = hes;
            Email = email;
        }
        
    }
}
