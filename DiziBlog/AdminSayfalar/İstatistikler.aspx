<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="İstatistikler.aspx.cs" Inherits="DiziBlog.AdminSayfalar.İstatistikler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>
                TOPLAM BLOG SAYISI : <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </th>
            <th>
                TOPLAM YORUM SAYISI : <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </th>
            <th>
                FİLM SAYISI : <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </th>
        </tr>
        <tr>
            <th>
                TOPLAM DİZİ SAYISI : <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </th>
            <th>
                TOPLAM ANİMASYON SAYISI : <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </th>
            <th>
                EN FAZLA YORUMLU BLOG : <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </th>
        </tr>
    </table>
</asp:Content>
