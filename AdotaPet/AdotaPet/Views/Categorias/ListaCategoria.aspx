﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCategoria.aspx.cs" Inherits="AdotaPet.Views.Categorias.ListaCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <h1> Categorias</h1>
    <asp:GridView ID="gvCategorias" runat="server">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir"/>
            <asp:ButtonField CommandName="Editar" Text="Editar"/>
        </Columns>
    </asp:GridView>
    
</asp:Content>
