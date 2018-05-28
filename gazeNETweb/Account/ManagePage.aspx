<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MasterPageAfterLogin.master" AutoEventWireup="true" CodeFile="ManagePage.aspx.cs" Inherits="ManagePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Manage.css" rel="stylesheet" type="text/css" /> 
    <title>Manage</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div style="height: 847px; margin-top: 22px; font-size: x-large;">
    
        <div style="height: 45px">
        </div>
        <div style="border-style: double; border-width: medium; background: #CCCCCC; height: 31px; margin-top: 25px; font-size: medium; font-style: normal;">
           
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton1" CssID="Manage.css" runat="server" PostBackUrl="~/Account Page.aspx">Account Page</asp:LinkButton>&nbsp;&nbsp; <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl=" ">User Settings</asp:LinkButton></div>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; USER SETTINGS&nbsp;</p>
        <div style="background: #CCCCCC; height: 290px; margin-left: 15px; margin-right: 15px">
            <br />
        <div style="height: 25px; margin-top: 0px; font-size: large">
            &nbsp;&nbsp; Change Password
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Old Password&nbsp;
            <asp:TextBox ID="Password" runat="server" Width="175px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; New Password&nbsp;
            <asp:TextBox ID="new_password" runat="server" Width="175px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; Confirm Password&nbsp;
            <asp:TextBox ID="confirm_new" runat="server" Width="175px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ChangePassword" runat="server" Text="Change Password" OnClick="ChangePassword_Click" Width="135px" ForeColor="Green" />
        </div>
        </div>
        <p>
            &nbsp;</p>
        <div style="background: #CCCCCC; height: 199px; margin-left: 15px; margin-right: 15px; font-size: large;">
            <br />
&nbsp;&nbsp; E-Mail Change<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Current Mail&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="175px" TextMode="Email"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Change Mail&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="175px" TextMode="Email"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" style="margin-left: 0px" Text="Confirm" Width="135px" ForeColor="Green" />
        </div>
        </div>
</asp:Content>

