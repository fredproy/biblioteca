<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Libro.aspx.cs" Inherits="Biblioteca.Web.Libro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <!-- formulario insert -->
    <div class="">
        <div class="col-lg-2">
            <asp:Label ID="Label1" runat="server">Titulo</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label ID="Label2" runat="server">Autor</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtAutor" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label ID="Label3" runat="server">Editorial</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtEditorial" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label ID="Label4" runat="server">Anho</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtAnho" CssClass="" type="date" />
    </div>
    <div class="">
        <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
    <!-- fin del formulario insert -->

    <br />
    <br />
    
    
     <!-- Inicio del listview -->    
        <asp:ListView runat="server" ID="lvLibro" ItemType="Biblioteca.BE.LibroBE" SelectMethod="getAllLibro">
            <LayoutTemplate>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <td>ID</td>
                            <td>Titulo</td> 
                            <td>Autor</td>
                            <td>Editorial</td>
                            <td>Anho</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr runat="server" id="itemPlaceholder" />
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.IdLibro %></td>
                    <td><%# Item.Titulo %></td>
                    <td><%# Item.Autor %></td>
                    <td><%# Item.Editorial %></td>
                    <td><%# Item.Anho %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    
    <!-- fin del listview -->
    
</asp:Content>
