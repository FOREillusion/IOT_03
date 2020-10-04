using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public class SessionLogin : System.Web.UI.Page
{
    public SessionLogin()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    protected void Page_Init(object sender, EventArgs e)
    { 
        if(Session["UserInfo"]==null)
        {
            Response.Redirect("login,aspx");
        }
    }
}
public partial class _Default : SessionLogin
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Session["UserInfo"] + ",欢迎登录！");
    }
}