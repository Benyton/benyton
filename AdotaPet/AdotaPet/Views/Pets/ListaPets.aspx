﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPets.aspx.cs" Inherits="AdotaPet.Views.Pets.ListaPets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Pets</h1>
    <asp:GridView ID="gvPets" runat="server">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir"/>
            <asp:ButtonField CommandName="Editar" Text="Editar"/>
        </Columns>
    </asp:GridView>

    <br />
    <asp:Label ID="lblCodigo" runat="server" Text="Categoria"></asp:Label>
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblRaca" runat="server" Text="Raça"></asp:Label>
    <asp:TextBox ID="txtRaca" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:RadioButtonList ID="rdbSexo" runat="server">
        <asp:ListItem Text="Macho" Value="macho" runat="server"></asp:ListItem> 
        <asp:ListItem Text="Femea" Value="femea" runat="server"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:Button CssClass="btn btn-success"  ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnSalvar_Click" />
    <asp:Button CssClass="btn btn-warning" ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
