<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Home</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.mim.js"></script>
<body>
    <img src="https://imagizer.imageshack.com/img923/8149/e7paML.jpg " width="400" height="200"/>
    <form id="form1" runat="server">
    <div class="container" style="background-color:red">
        <div class="row">

    </div></div>
        <h3 class="well">Seja Bem Vindo</h3>
        <br />
            SELECIONE A OPERAÇÃO DESEJADA:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text="Escolha uma opção - " />
                <asp:ListItem Value="1" Text="Cadastrar Aluno - " />
                <asp:ListItem Value="2" Text="Consultar Aluno - " />
                <asp:ListItem Value="3" Text="Obter os dados do Aluno - " />
            </asp:DropDownList>
            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-success" OnClick="btnacessar" />

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        
    </form>
</body>
</html>