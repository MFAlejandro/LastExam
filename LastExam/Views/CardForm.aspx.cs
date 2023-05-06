using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using m = LastExam.Model;
using c = LastExam.Controller;
using System.Reflection.Emit;

namespace LastExam.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateCard_ServerClick(object sender, EventArgs e)
        {
            string msg = string.Empty;
            Dictionary<string, string> Colores = new Dictionary<string, string>
            {
                { "1", "card text-bg-danger mb-3" },
                { "2", "card text-bg-dark mb-3" },
                { "3", "card text-bg-white mb-3" },
                { "4", "card text-bg-primary mb-3" },
                { "5", "card text-bg-success mb-3" }
            };
            Dictionary<string, string> Emisores = new Dictionary<string, string>
            {
                { "1", "../Images/Visa.png" },
                { "2", "../Images/MasterCard.png" }
            };
            Dictionary<string, string> Bancos = new Dictionary<string, string>
            {
                { "1", "Banco Promerica" },
                { "2", "Banco de Costa Rica"},
                { "3", "BAC Credomatic" }
            };

            string emisor = Emisores[Emisor.SelectedIndex.ToString()];
            string color = Colores[Color.SelectedIndex.ToString()];
            string banco = Bancos[Banco.SelectedIndex.ToString()];

            m.Card card = new m.Card()
            {
                Name = Name.Value.ToString(),
                CardNumber = CardNumber.Value.ToString(),
                ExperationDate = Convert.ToDateTime(date.Value.ToString(), CultureInfo.InvariantCulture),
                CVV = CVV.Value.ToString(),
                Banco = banco.ToString(),
                Color = color.ToString(),
                Emisor = emisor.ToString()
            };

            c.Card cardController = new c.Card();
            if (cardController.SaveCard(card))
            {
                msg = "Your card was succesfully created";
                
            }
            else
            {
                msg = "Something is wrong, contact with services team";
                
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showModal('Login','" + msg + "')", true);
            
           
        }

        protected void btnModal_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("../Views/PrincipalPage.aspx");
        }
    }
}