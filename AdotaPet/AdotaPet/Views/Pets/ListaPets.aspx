<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPets.aspx.cs" Inherits="AdotaPet.Views.Pets.ListaPets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Pets</h1>
    <asp:GridView ID="gvPets" runat="server" OnRowCommand="gvCategorias_RowCommand"  OnSelectedIndexChanged="gvPets_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
</asp:Content>
