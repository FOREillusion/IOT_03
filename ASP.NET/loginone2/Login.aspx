<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        编号:<asp:TextBox ID="TextBox1" runat="server" Height="38px"></asp:TextBox>
        <br />
        <br />
        <br />
        密码:<asp:TextBox ID="TextBox2" runat="server" Height="40px"></asp:TextBox>
        <br />
         验证码：<asp:TextBox 
            ID="tbx_yzm" runat="server" Width="59px" Height="24px"></asp:TextBox>
<asp:ImageButton ID="ibtn_yzm" runat="server" Width="35px" />
<a href="javascript:changeCode()" style="text-decoration: underline; font-size:10px;">换一张</a>
<script type="text/javascript">
    function changeCode() {
        document.getElementById('ibtn_yzm').src = document.getElementById('ibtn_yzm').src + '?';
    }
</script>
        <br />
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="登录" 
        Width="105px" />
    </form>
</body>
</html>
