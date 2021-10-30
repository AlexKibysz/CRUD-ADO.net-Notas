<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaNota.aspx.cs" Inherits="AgendaWeb.NuevaNota" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 76px;
            height: 72px;
        }
    </style>
    <div>

        <h1>Nueva Nota</h1>
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción:"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"></asp:TextBox>
        <br />
        <h3>Seleccionar Fecha de Entrega</h3>
        <asp:Calendar runat="server" ID="fechaEntregaCalendario"></asp:Calendar>
        <p />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </div>
</asp:Content>