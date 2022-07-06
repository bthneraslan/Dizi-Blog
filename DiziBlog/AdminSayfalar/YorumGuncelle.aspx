<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziBlog.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form runat="server" class="form form-group">

        <asp:Label ID="Label7" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TxtID" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label1" runat="server" Text="KULLANICI ADI"></asp:Label>
        <asp:TextBox ID="TxtKadı" CssClass="form-control" runat="server" ></asp:TextBox>
        <br />

        <asp:Label ID="Label2" runat="server" Text="MAİL"></asp:Label>
        <asp:TextBox ID="TxtMail" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label6" runat="server" Text="YORUM"></asp:Label>
        <asp:TextBox ID="TxtYorum" TextMode="MultiLine" Rows="2" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

         <asp:Label ID="Label3" runat="server" Text="BLOG"></asp:Label>
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataTextField="BLOGBASLIK" DataValueField="BLOGID"></asp:DropDownList>
        <br />
        
        

        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="GÜNCELLE" OnClick="Button1_Click"    />
        
    </form>
</asp:Content>
