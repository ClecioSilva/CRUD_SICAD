<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
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
        <h3 class="well">Detalhes dos Alunos</h3>
        <br />

        Informe o Código: <br />
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%"/>
        <br />                   
        <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarAluno" />
        <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
        <br />

        <p>
            <asp:Label ID="lblMemsagem" runat="server" />
        </p>

        <asp:Panel ID="pnlDados" runat="server">

        Nome do Aluno: <br />
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%"/>
        <br />

        Data Nascimento: <br />
        <asp:TextBox ID="txtData_Nasc" runat="server" CssClass="form-control" Width="40%"/>
        <br />

        Idade: <br />
        <asp:TextBox ID="txtIdade" runat="server" CssClass="form-control" Width="30%"/>
        <br />

        Objetivo_Graduacao: <br />
        <asp:TextBox ID="txtObjetivo_Graduacao" runat="server" CssClass="form-control" Width="30%"/>
        <br />

        Genero: <br />
        <asp:TextBox ID="txtGenero" runat="server" CssClass="form-control" Width="30%"/>
        <br />

        <p>
            <asp:Label ID="lblMensagem" runat="server"/>
        </p>

        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirUsuario" />
        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-success btn-lg" OnClick="BtnAtualizarUsuario"  />
        </asp:Panel>

    </form>
</body>
</html>
