using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using m = LastExam.Model;

namespace LastExam.Controller
{
    public class Card
    {
        public List<m.Card> GetCards()
        {
            DataBaseWebHelper.DataBase db = new DataBaseWebHelper.DataBase();

            DataTable ds = db.GetCards();

            return ConvertDSToList(ds);

        }

        //Method save a new alarm
        public bool SaveCard(m.Card card )
        {
            try
            {
                DataBaseWebHelper.DataBase db = new DataBaseWebHelper.DataBase();

                db.SaveCard(card);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<m.Card> ConvertDSToList(DataTable ds)
        {
            List<m.Card> CardList = new List<m.Card>();

            foreach (DataRow row in ds.Rows)
            {
                CardList.Add(new m.Card
                {
                    Name = row["Name"].ToString(),
                    CardNumber = row["CardNumber"].ToString(),
                    ExperationDate = Convert.ToDateTime(row["ExpirationDate"]),
                    CVV = row["CVV"].ToString(),
                    Banco = row["Banco"].ToString(),
                    Color = row["Color"].ToString(),
                    Emisor = row["Emisor"].ToString(),
                });
            }

            return CardList;
        }

    }
}