<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmergencyText.aspx.cs" Inherits="SoundMind.EmergencyText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<body>
     <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrapcer.css" rel="stylesheet" />
    <form id="form1" runat="server">
        
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="http://localhost:3811/">Sound Mind</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="http://localhost:3811/">Home</a></li>
                        <li><a runat="server" href="http://localhost:3811/Home/About">Quote of the day</a></li>
                        <li><a runat="server" href="http://localhost:3811/Home/Contact">Contact</a></li>
                    </ul>
                    <asp:LoginView runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a runat="server" href="http://localhost:3811/Account/Register">Register</a></li>
                                <li><a runat="server" href="http://localhost:3811/Account/Login">Log in</a></li>
                            </ul>
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a runat="server" href="~/Account/Manage" title="Manage your account">Hello!</a></li>
                            </ul>
                        </LoggedInTemplate>
                    </asp:LoginView>
                </div>
            </div>
        </div>
    <div style="padding-left: 50px">
        <h2 style="color:black">Emergency Text</h2><br />
        <h3 style="color:black">Send an emergency text message to anyone.</h3><br />
    <h4 style="color:black">Change the number here.</h4>
    <asp:TextBox ID="EmergencyTextNumber" runat="server">414-335-8283</asp:TextBox>
        <h4 style="color:black">Change your message here.</h4>
        <asp:TextBox ID="Message" runat="server">I need help now. Text or call me as soon as possible.</asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SendMessage" runat="server" Text="Send Emergency Text" OnClick="SendMessage_OnClick" />
    </div>
    </form>
    <br />
    <br />
</body>
</html>
