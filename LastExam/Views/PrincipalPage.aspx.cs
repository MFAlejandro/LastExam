using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using c = LastExam.Controller;

namespace LastExam.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            c.Card cardController = new c.Card();
            repCards.DataSource = cardController.GetCards();
            repCards.DataBind();

        }

        protected void repCards_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                // Obtener el Label del número de tarjeta en el ItemTemplate
                Label lblCardNumber = (Label)e.Item.FindControl("lblCardNumber");

                // Obtener el número de tarjeta actual
                string cardNumber = lblCardNumber.Text;

                // Obtener los últimos 4 dígitos del número de tarjeta
                string last4Digits = cardNumber.Substring(cardNumber.Length - 4);

                // Reemplazar los dígitos restantes con "X"
                string maskedCardNumber = "X-X-X-X-X-X-X-X-X-" + last4Digits;

                // Establecer el nuevo valor en el Label
                lblCardNumber.Text = maskedCardNumber;
            }
        }



    }
}