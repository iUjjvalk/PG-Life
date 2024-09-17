using System; using System.Collection
Generic; using System.Linq; using System.Web; using
System.Web.UI; using System.Web.UI.WebControls;
public partial class LoginModule :
System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
}
protected void btnSignUp_Click(object sender, EventArgs e)
{
SqlDataSource1.InsertParameters["Username"].DefaultValue = txtUserName.Text;
SqlDataSource1.InsertParameters["Password"].DefaultValue = txtPassword.Text;
SqlDataSource1.Insert(); lblResult.Text = "User Added";
}
}