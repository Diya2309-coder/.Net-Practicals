using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac__10
{
    public partial class Default : System.Web.UI.Page
    {
        private string Label2;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "This is the label in the default theme.";

        }
    }
}