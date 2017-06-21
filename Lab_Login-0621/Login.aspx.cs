using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text =="") {
           lblPrompt.Text=" Pls key in your UserName.";
            return;
        }
        if (txtPassword.Text == "") {
            lblPrompt.Text = " Pls key in your Password.";
            return;
        }



        Session["userName"] = txtUserName.Text;
        if (Session["userName"] == null) {
            Response.Redirect("Login.aspx");
        } 
        else {
            Response.Redirect("Secret.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e) {
        txtUserName.Text = "";
        txtPassword.Text = "";

    }
}



 