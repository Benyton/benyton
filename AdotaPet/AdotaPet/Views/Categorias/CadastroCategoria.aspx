<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="AdotaPet.Views.Categorias.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastrar Categorias</h1>
    <br />
    <br />
    <asp:Label ID="lblPorte" runat="server" Text="Porte"></asp:Label>
    <asp:TextBox ID="txtPorte" runat="server"></asp:TextBox>
    <br />
    <asp:Button CssClass="btn btn-success"  ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
