<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Biblioteca.Web.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="gvUsuario" ItemType="Biblioteca.BE.UsuarioBE" SelectMethod="getAllUsuario">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>ID</td>
                            <td>Nombres</td> 
                            <td>Apellidos</td>
                            <td>Direccion</td>
                            <td>Telefono</td>
                            <td>Dni</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr runat="server" id="itemPlaceholder" />
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.IdUsuario %></td>
                    <td><%# Item.Nombre %></td>
                    <td><%# Item.Apellido %></td>
                    <td><%# Item.Direccion %></td>
                    <td><%# Item.Telefono %></td>
                    <td><%# Item.Dni %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>
