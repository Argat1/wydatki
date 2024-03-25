using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace wydatki
{
     public class Wydatek
    {
        
        public int id {  get; set; }
        public DateTime data { get; set; }
        public string nazwa { get; set; }
        public decimal kwota { get; set; }
            
    }
}
