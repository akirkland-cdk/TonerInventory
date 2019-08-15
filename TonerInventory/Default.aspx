<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TonerInventory.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Label runat="server" Text="Toner Name"></asp:Label>
<asp:TextBox runat="server" ID="TonerNameTextBox"></asp:TextBox>
<asp:Label runat="server" Text="Quantity on Hand"></asp:Label>
<asp:TextBox runat="server" ID="QoHTextBox"></asp:TextBox>
<asp:Label runat="server" Text="Reorder Quantity"></asp:Label>
<asp:TextBox runat="server" ID="ReQty"></asp:TextBox>
<asp:Label runat="server" Text="Number of Printers"></asp:Label>
<asp:TextBox runat="server" ID="NoPrinters"></asp:TextBox>
<br />
 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


<asp:Label runat="server" ID="Msglabel"></asp:Label>


</asp:Content>
