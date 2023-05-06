using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastExam.Model
{
    public class Card
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExperationDate { get; set; }
        public string CVV { get; set; }
        public string Color { get; set; }
        public string Banco { get; set; }
        public string Emisor { get; set; }
    }
}