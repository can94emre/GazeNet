
<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageBeforeLogin.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default " %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <title>Login</title>
    <link href="../Bootstrap login/bootstrap.min.css" rel="stylesheet" />
    <link href="../Bootstrap login/Style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server" >
    <div runat="server" style="background-image:url('../Image/gazee.jpg'); height:600px">
    
        <div class="panel-img">
            <img src="../Image/Panel.png" />
        </div>
        <div>
            <div style="position:absolute; z-index:1;" id="layer1">
                <div class="modal-body" style="margin:30px 0px 0px 400px;">
                    <div class="row">
                        <div class="col-xs-6">
                            <div class="form-group">
                                <label for="ID" class="control-label">User ID</label>
                                <asp:TextBox ID="ID" runat="server" CssClass="form-control"></asp:TextBox>
                                <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="password" class="control-label">Password</label>
                                <asp:TextBox runat="server" ID="password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                 <span class="help-block"></span>
                            </div>

                             <asp:Button runat="server" OnClick="LoginBtn" Text="Login" Class="btn btn-success btn-block" />
                            <asp:Button runat="server" OnClick="ForgetPasswordBtn" Text="Forget Password" Class="btn btn-default btn-block" />
                            
                        </div>
                        <div class="col-xs-6">

                        <p class="lead">Not have an Account?<span class="text-success"><a href="SignUp.aspx">Sign Up</a></span></p>
                        
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
 
    <script src="../js/jquery-3.1.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
        </div>
</asp:Content>