using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Login : System.Web.UI.Page
{
    public string cons = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        ibtn_yzm.ImageUrl = "ImageCode.aspx";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //验证码登录，不区分大小写
        string code = tbx_yzm.Text;
        HttpCookie htco = Request.Cookies["ImageV"];
        string scode = htco.Value.ToString();
        string smallcode_01 = scode.ToLower();
        string smallcode_02 = code.ToLower();
        if (smallcode_01 != smallcode_02)
        {//如果验证码不正确，则弹出提示对话框
            Response.Write("<script>alert('验证码输入不正确！')</script>");
        }
        else
        {
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sql = "select uname from users where ucode=@xx and upwd=@yy";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] pms = new SqlParameter[] { 
            new SqlParameter("@xx",SqlDbType.NVarChar,50){Value=this.TextBox1.Text.ToString()},
            new SqlParameter("@yy",SqlDbType.NVarChar,50){Value=this.TextBox2.Text.ToString()}};

                cmd.Parameters.AddRange(pms);

                try
                {
                    object na = cmd.ExecuteScalar();
                    if (na != null)
                    {
                        Session["UserInfo"] = na.ToString();
                        Response.Redirect("Default.aspx");
                    }
                    else
                    { Response.Write("<script>window.alert('编号或密码错误，请重新输入！')</script>"); }
                }
                catch
                { Response.Write("<script>window.alert('发生异常')</script>"); }
            }
        }
    }
}
