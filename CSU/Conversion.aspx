<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="ConvertidorNumeroATexto.CSU.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="BtnDolar">
            <asp:Label runat="server" Text="Label">Numero:</asp:Label><asp:TextBox runat="server" ID="txtNumero"></asp:TextBox>
            
            <br class="Apple-interchange-newline"><br><asp:Label runat="server" Text="Convertir a: "></asp:Label>
            
            <asp:Button runat="server" Text="Letras" ID="BtnLetra" OnClick="BtnLetra_Click"></asp:Button><asp:Button runat="server" Text="Dolares" OnClick="Unnamed2_Click"></asp:Button><br><br><asp:Label runat="server" Text="Respuesta:"></asp:Label><br>
            <asp:TextBox ID="TxtRespuesta" runat="server"></asp:TextBox>
            

         </div>   
    </form>
</body>
</html>

