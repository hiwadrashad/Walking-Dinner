<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="begin.aspx.cs" Inherits="Walking_Dinner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:ListBox ID="ListBox1" runat="server" ForeColor="Black"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="Black" Text="creëer/toetreden nieuwe groep" style="z-index: 1; left: 478px; top: 320px; position: absolute; height: 56px" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="Black" style="z-index: 1; left: 204px; top: 124px; position: absolute; width: 95px" Text="Walking Dinners"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Black" style="z-index: 1; left: 519px; top: 270px; position: absolute" Text="Parallele gastheer"></asp:Label>    
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 619px; top: 123px; position: absolute; height: 56px; bottom: 238px;" OnCheckedChanged="CheckBox1_CheckedChanged" />
    </div>

    </asp:Content>
