<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="AgendaWeb.Notas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:GridView runat="server" ID="gridNotasList" OnRowDataBound="gridNotasList_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="Both" AutoGenerateColumns="false">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="idNota" HeaderText="Código" />
                <asp:BoundField DataField="Mensaje" HeaderText="Descripción" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="False" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:Button Text="crear" ID="btn_crear" OnClick="btn_crear_Click" runat="server" />
        <asp:Button Text="edit" ID="btn_editar" OnClick="btn_editar_Click" runat="server" />
        <asp:Button Text="eliminar" ID="btn_eliminar" OnClick="btn_eliminar_Click" runat="server" />
    </div>
</asp:Content>