﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarNota.aspx.cs" Inherits="AgendaWeb.EditarNota" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 76px;
            height: 72px;
        }
    </style>
    <div>

        <h1>Nota</h1>
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción:"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"></asp:TextBox>
        <br />

        <p />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click1" />
    </div>
</asp:Content>