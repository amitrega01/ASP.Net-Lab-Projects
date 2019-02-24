<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RssReader.aspx.cs" Inherits="WebFormsDemo.RssReader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:TextBox ID="RssText" runat="server" Height="52px" Width="408px" ToolTip="Kanał rss"  CssClass="form-control"></asp:TextBox>
    <asp:Button ID="BtnLoad" runat="server" Height="48px" OnClick="BtnLoad_Click" Text="Button" Width="86px" CssClass="btn btn-success"/>
    
    <asp:Repeater ID="Repeater1" runat="server" 
        ItemType="WebFormsDemo.models.RssItem"
        >
        
        <ItemTemplate>
            <h1><%# Item.Title %></h1>
            <h4><%# Item.PubDate%></h4>
            <h4><%# Item.Description %></h4>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
