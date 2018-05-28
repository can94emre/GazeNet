<%@ Page Language="C#" MasterPageFile="~/Masters/MasterPageBeforeLogin.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Sign Up</title>
    <link href="../Bootstrap login/bootstrap.min.css" rel="stylesheet" />
    <link href="../Bootstrap login/Style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server" >
    <div runat="server" style="background-image:url('../Image/gazee.jpg'); height:730px">
         <div class="panel-img">
            
        </div>
        <div style="position:absolute; z-index:1;" id="layer1">
                <div class="modal-body" style="margin:-100px 0px 0px 400px;">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="form-group">
                                <label for="name" class="control-label">Name</label>
                                
                               <asp:TextBox runat="server" ID="name" CssClass="form-control"></asp:TextBox>
                                <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="usermail" class="control-label">Mail</label>
                                <asp:TextBox ID="usermail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="ID" class="control-label">Id</label>
                                <asp:TextBox runat="server" ID="ID" CssClass="form-control" ></asp:TextBox>
                                <asp:RegularExpressionValidator ErrorMessage="Please enter valid ID" runat="server" CssClass="alert-danger" ValidationExpression="^\d+$" ControlToValidate="ID">

                                </asp:RegularExpressionValidator>
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="gender" class="control-label">Gender</label>
                                <asp:TextBox runat="server" ID="gender" CssClass="form-control" ></asp:TextBox>
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="birthday" class="control-label">Birthday</label>
                                 
                                <asp:TextBox runat="server" ID="birthday" CssClass="form-control" TextMode="Date" ></asp:TextBox>
                                
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="job" class="control-label">Job</label>
                                <asp:TextBox runat="server" ID="job" CssClass="form-control"></asp:TextBox>
                                
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="password" class="control-label">Password</label>
                                <asp:TextBox runat="server" ID="password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                 <span class="help-block"></span>
                            </div>
                            <div class="form-group">
                                <label for="confirmpassword" class="control-label">Confirm Password</label>
                                <asp:TextBox runat="server" ID="confirmpassword" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                 <span class="help-block"></span>
                            </div>
                            <div >
                            <br />
                           <asp:Button runat="server" OnClick="SignUpBtn" Text="Sign Up" Class="btn btn-success btn-block" />
                            </div>                           
                        </div>
                    </div>                   
                </div>
            </div>
        </div>
     <script src="../js/jquery-3.1.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</asp:Content>

