using System;

public partial class HelloWorld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Hello, World! This is your .cs file running on IIS.";
    }
}
