using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_ex_3
{
    public partial class pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookBezoeker1 = new HttpCookie("Bezoeker");
            cookBezoeker1.Value = Convert.ToString( Convert.ToInt32(cookBezoeker1)+1);
            Response.Cookies.Add(cookBezoeker1);
            lblTeller.Text = Convert.ToString( cookBezoeker1);

        }
    }
}