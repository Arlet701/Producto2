<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="COVID_PRESENTACION.Agregar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <link href="Estilos/Estilo.css" rel="stylesheet" />
    <br />
    <br />
    <br />
<<<<<<< HEAD
    Seleccione el registro que desea consultar:
=======
    Seleccione el registro que desea hacer:
>>>>>>> a4a1657 (Se crean inserciones)
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Button Id="Button1" runat="server" Text="Consulta para agregar" OnClick="Button1_Click"/>

</asp:Content>
