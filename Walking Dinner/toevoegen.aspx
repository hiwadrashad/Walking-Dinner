<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="toevoegen.aspx.cs" Inherits="Walking_Dinner.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 28px; top: 113px; position: absolute; width: 107px; height: 27px" Text="Volledige naam"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 147px; top: 113px; position: absolute" Text="Straatnaam"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 239px; top: 113px; position: absolute" Text="Huisnummer"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 346px; top: 113px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 456px; top: 112px; position: absolute" Text="Plaats"></asp:Label>
        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 514px; top: 112px; position: absolute; right: 350px;" Text="Telefoonnummer"></asp:Label>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 640px; top: 113px; position: absolute" Text="E-mailadress"></asp:Label>
        <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 740px; top: 113px; position: absolute" Text="Dieetwensen"></asp:Label>
        <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 353px; top: 215px; position: absolute; width: 140px" Text="Partner (optioneel)"></asp:Label>
        <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 28px; top: 250px; position: absolute; width: 107px; height: 27px" Text="Volledige naam"></asp:Label>
        <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 147px; top: 250px; position: absolute" Text="Straatnaam"></asp:Label>
        <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 239px; top: 250px; position: absolute" Text="Huisnummer"></asp:Label>
        <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 346px; top: 250px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 456px; top: 250px; position: absolute" Text="Plaats"></asp:Label>
        <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 514px; top: 250px; position: absolute; right: 350px;" Text="Telefoonnummer"></asp:Label>
        <asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 640px; top: 250px; position: absolute" Text="E-mailadress"></asp:Label>
        <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 740px; top: 250px; position: absolute" Text="Dieetwensen"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black" ></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 132px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 232px; top: 149px; position: absolute " ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 332px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 432px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 532px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 632px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 732px; top: 149px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server"  style="z-index: 1; left: 32px; top: 300px; position: absolute" ForeColor="Black" ></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 132px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox11" runat="server" style="z-index: 1; left: 232px; top: 300px; position: absolute " ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox12" runat="server" style="z-index: 1; left: 332px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox13" runat="server" style="z-index: 1; left: 432px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox14" runat="server" style="z-index: 1; left: 532px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox15" runat="server" style="z-index: 1; left: 632px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>
        <asp:TextBox ID="TextBox16" runat="server" style="z-index: 1; left: 732px; top: 300px; position: absolute" ForeColor="Black"></asp:TextBox>

    </p>
    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="Black" Text="Toevoegen" OnClick="Button1_Click" />
  </asp:Content>
