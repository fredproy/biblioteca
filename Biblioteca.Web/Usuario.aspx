<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Biblioteca.Web.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />

    <!-- formulario insert -->
    <div class="">
        <div class="col-lg-2">
            <asp:Label runat="server">Nombres</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label runat="server">Apellidos</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label runat="server">Direccion</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label runat="server">Telefono</asp:Label>
        </div>        
        <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
    </div>
    <div class="">
        <div class="col-lg-2">
            <asp:Label runat="server">Dni</asp:Label>
        </div>
        <asp:TextBox runat="server" ID="txtDni" CssClass="form-control" />
    </div>
    <div class="">
        <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
    <!-- fin del formulario insert -->

    <br />
    <br />

    <!-- Inicio del listview -->    
        <asp:ListView runat="server" ID="lvUsuario" ItemType="Biblioteca.BE.UsuarioBE" SelectMethod="getAllUsuario">
            <LayoutTemplate>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <td>Nombres</td> 
                            <td>Apellidos</td>
                            <td>Direccion</td>
                            <td>Telefono</td>
                            <td>Dni</td>
                            <td colspan="2">Acciones</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr runat="server" id="itemPlaceholder" />
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.Nombre %></td>
                    <td><%# Item.Apellido %></td>
                    <td><%# Item.Direccion %></td>
                    <td><%# Item.Telefono %></td>
                    <td><%# Item.Dni %></td>
                    <td>
                        <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-default" CommandArgument="<%# Item.IdUsuario %>" CommandName="Eliminar" OnClick="btnEliminar_Click" />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    
    <!-- fin del listview -->    
    
</asp:Content>
