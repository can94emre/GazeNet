<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MasterPageAfterLogin.master" AutoEventWireup="true" CodeFile="Question_Count.aspx.cs" Inherits="Account_Question_Count" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <asp:TextBox ID="q_count" runat="server" AutoPostBack="true"  OnTextChanged="q_count_TextChanged"></asp:TextBox>
</asp:Content>

