<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziBlog.AdminSayfalar.Bloglar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>TARİH</th>
            <th>TÜR</th>
            <th>KATEGORİ</th>
            <th>İÇERİK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BLOGID") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td><%# Eval("BLOGTARIH") %></td>
                    <td><%# Eval("BLOGTUR") %></td>
                    <td><%# Eval("BLOGKATEGORI") %></td>
                    <td><%# Eval("BLOGICERIK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "BlogSil.aspx?BLOGID=" + Eval("BLOGID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                    </td>
                    <td><asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "BlogGuncelle.aspx?BLOGID="+ Eval("BLOGID") %>' CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="BlogEkle.aspx" class="btn btn-info"> Yeni Blog</a>
</asp:Content>
