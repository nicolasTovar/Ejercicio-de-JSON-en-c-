<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="practicarJson.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCedula" runat="server" Text="Cedula"></asp:Label>
            <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
            <br />
          
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            
            <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />
            <asp:Button ID="btnLeer" runat="server" Text="Leer JSON" OnClick="btnLeer_Click" />
            <br />
              <asp:ListBox ID="lbDatos" runat="server" Width="608px"></asp:ListBox>
            <br />
            <asp:GridView ID="dgInformacio" runat="server"></asp:GridView>


        </div>
    </form>
</body>
</html>
