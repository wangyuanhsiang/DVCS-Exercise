using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtInput.Focus();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblStatus.Text = txtInput.Text.ToString();
    }
}