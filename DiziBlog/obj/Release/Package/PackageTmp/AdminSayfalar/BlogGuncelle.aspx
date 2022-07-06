<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="BlogGuncelle.aspx.cs" Inherits="DiziBlog.AdminSayfalar.BlogGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form form-group">

        <asp:Label ID="Label7" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TxtID" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label1" runat="server" Text="BAŞLIK"></asp:Label>
        <asp:TextBox ID="TxtBaslik" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label2" runat="server" Text="TARİH"></asp:Label>
        <asp:TextBox ID="TxtTarih" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label5" runat="server" Text="GÖRSEL"></asp:Label>
        <asp:TextBox ID="TxtGorsel" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label3" runat="server" Text="TÜR"></asp:Label>
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataTextField="TURAD" DataValueField="TURID"></asp:DropDownList>
        <br />
         <asp:Label ID="Label4" runat="server" Text="KATEGORİ"></asp:Label>
        <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" DataTextField="KATEGORIAD" DataValueField="KATEGORIID"></asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="İÇERİK"></asp:Label>
        <asp:TextBox ID="Txtİcerik" TextMode="MultiLine" Rows="5" CssClass="form-control" runat="server"></asp:TextBox>
        <br />


        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="GÜNCELLE" OnClick="Button1_Click"   />
        
    </form>
</asp:Content>
