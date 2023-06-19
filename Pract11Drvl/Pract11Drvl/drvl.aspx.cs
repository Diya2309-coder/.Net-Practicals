using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract11Drvl
{
    public partial class drvl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["data"] != null)
            {
                Label1.Text = Session["data"].ToString();
            }
        }
    }
}