<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RssReader.aspx.cs" Inherits="WebFormsDemo.RssReader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .card {
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.25);
            width: 320px;
            float: left;
            display: block;
            flex: 1;
            padding: 16px;
            margin: 16px;
            border: 0.5px solid rgba(0,0,0,0.25);
            transition: 0.3s;
            height: 312px;
        }

            .card:hover {
                box-shadow: 0 5px 10px rgba(0,0,0,0.25);
            }

        h1 {
            padding: 0;
            margin: 0;
            max-width: 300px;
            font-size: 1.4em;
            font-weight: bold;
            text-align: left;
            margin-bottom: 8px;
            text-decoration: none;
        }

        a {
            text-decoration: none;
            color: inherit;
        }

            a:hover {
                text-decoration: none;
                color: inherit;
            }

        .pubDate {
            font-size: 10px;
            color: rgba(0,0,0,0.5);
            margin: 0;
            padding: 0;
        }


        p {
            color: rgba(0,,0,0,0.75);
            overflow: hidden;
            text-overflow: ellipsis;
            display: -webkit-box;
            -webkit-box-orient: vertical;
            text-align: justify;
            -webkit-line-clamp: 10; /* number of lines to show */
            line-height: 18px; /* fallback */
            max-height: 180px; /* fallback */
        }

            p img {
                display: none;
            }

        .row {
            display: flex;
            margin-top: 16px;
            flex-direction: row;
            flex-wrap: wrap;
            justify-content: center;
            margin: 16px auto;
            width: 100%;
        }

        .input {
            align-self: stretch;
            border: 0.5px solid rgba(0,0,0,0.25);
            border-radius: 10px 0 0 10px;
            padding: 16px;
            text-align: center;
            flex: 1 100%;
        }

        .button {
            border-radius: 0 10px 10px 0;
            border: 0.5px solid rgba(0,0,0,0.25);
            padding: 16px;
            background-color: rgba(0,0,0,0.85);
            color: white;
            transition: 0.5s;
        }
        .button:hover {
            box-shadow: 0 5px 10px rgba(0,0,0,0.25);
            
            background-color: rgba(0,0,0,0.75);
        }
    </style>
    <div class="row" >
    <asp:TextBox ID="RssText" runat="server"  ToolTip="Kanał rss" CssClass="input"></asp:TextBox>
    <asp:Button ID="BtnLoad" runat="server" OnClick="BtnLoad_Click" Text="Odśwież" CssClass="button" Width="86px"/>

    </div>
    <div class="row" >
    <asp:Repeater ID="Repeater1" runat="server"
        ItemType="WebFormsDemo.models.RssItem">

        <ItemTemplate>
            <a class="link" href="<%# Item.Link %>"">
                <div class="card">

                <h1><%# Item.Title %></h1>
                <span class="pubDate"><%# Item.PubDate%></span>
                <p class="content"><%# Item.Description %></p>
            </div>
            </a>
        </ItemTemplate>
    </asp:Repeater>
        
        </div>
</asp:Content>
