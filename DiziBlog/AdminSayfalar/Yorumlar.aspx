<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziBlog.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>KULLANICI ADI</th>
            <th>MAİL</th>
            <th>YORUM</th>
            <th>BLOG</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("YORUMID") %></td>
                    <td><%# Eval("KULLANICIAD") %></td>
                    <td><%# Eval("MAIL") %></td>
                    <td><%# Eval("YORUMICERIK") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "YorumSil.aspx?YORUMID=" + Eval("YORUMID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                    </td>
                    <td><asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "YorumGuncelle.aspx?YORUMID="+ Eval("YORUMID") %>' CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
