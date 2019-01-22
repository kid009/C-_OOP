<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectWF.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">

            <div class="col-lg-6"><!-- left -->
                <div class="container">
                    <div class="row" style="padding-top: 10px;">
                        <div class="form-login" style="border: 1px solid black">

                            <div class="row" style="text-align: center">
                                <h4>Login WorkFlow Document</h4>
                            </div>
                            <hr />

                            <div class="row">
                                <div class="col-lg-6" style="text-align: right">
                                    <p>Username: </p>
                                </div>
                                <div class="col-lg-6" style="text-align: left">
                                    <asp:TextBox ID="txtUsername" runat="server" class="form-control" Width="90%"></asp:TextBox>
                                </div>
                            </div>
                            <br />

                            <div class="row">
                                <div class="col-lg-6" style="text-align: right">
                                    <p>Password: </p>
                                </div>
                                <div class="col-lg-6" style="text-align: left">
                                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" Width="90%" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <br />

                            <div class="row">
                                <div class="col-lg-6" style="text-align: right">
                                    <p>Role: </p> 
                                </div>
                                <div class="col-lg-6" style="text-align: left">
                                    <asp:DropDownList ID="ddlRole" runat="server" CssClass="dropdown form-control" Width="90%">
                                        <asp:ListItem Value="0">-- กรุณาเลือกประเภทผู้ใช้ --</asp:ListItem>
                                        <asp:ListItem Value="1">Admin</asp:ListItem>
                                        <asp:ListItem Value="2">Manager</asp:ListItem>
                                        <asp:ListItem Value="3">User</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <br />

                            <div class="row" style="text-align: center">
                                <span class="groud-btn">
                                    <asp:Button ID="btnSubmit" runat="server" Text="Login" class="btn btn-primary" />
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger" />
                                </span>                                
                            </div>
                            <br />

                        </div>
                    </div>
                </div>
            </div>

            <div class="col-lg-6"><!-- right -->               
                <asp:Image ID="Image1" runat="server" ImageUrl="" />                
            </div>

        </div>

    </div>

</asp:Content>
