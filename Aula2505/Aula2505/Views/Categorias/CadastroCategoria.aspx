<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="Aula2505.Views.Categorias.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Categorias</h1>
    <br />
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:CheckBox ID="ckbAtivo" runat="server" />
    <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
    <br />
    <br />
    <asp:Button CssClass="btn btn-success"  ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-success" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <asp:Button CssClass="btn btn-success" ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

</asp:Content>
