using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            // Loop through the uploaded files and process each one
            if (FileUpload1.HasFiles)
            {
                foreach (HttpPostedFile file in FileUpload1.PostedFiles)
                {
                    string filename = file.FileName;
                    file.SaveAs(Server.MapPath("~/Images/" + filename));
                    Image img = new Image();
                    img.ImageUrl = "~/Images/" + filename;
                    Controls.Add(img);
                    
                }

            }
        }

    }
}