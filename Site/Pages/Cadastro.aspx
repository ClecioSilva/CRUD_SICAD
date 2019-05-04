<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.mim.js"></script>
<body>
    <img src="https://imagizer.imageshack.com/img923/8149/e7paML.jpg " class="snpa10 col-lg-offset-1" class="well" width="400" height="200"/>
    <form id="form1" runat="server">
    <!--<div class="container" style="background-color:red">-->
        <div class="snpa10 col-lg-offset-1">
            <div class="row">

    </div>
        <h3 class="well">Cadastro de Aluno</h3>
        <br />

     
            Nome: <br />
        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
        <asp:RequiredFieldValidator
            ID="requiredNome"
            runat="server"
            ControlToValidate="txtNome"
            ErrorMessage="Por favor, digite seu Nome."
            ForeColor="Red"
            />
            <br />

        Data_Nasc: <br />
        <asp:TextBox ID="txtData_Nasc" runat="server" placeholder="Sua Data de Nascimento" Width="100%" CssClass="form-control"/>
        <asp:RequiredFieldValidator
            ID="requiredData_Nasc"
            runat="server"
            ControlToValidate="txtData_Nasc"
            ErrorMessage="Por favor, digite sua data de nascimento."
            ForeColor="Red"
            />
            <br />

        Idade: <br />
        <asp:TextBox ID="txtIdade" runat="server" placeholder="Sua Idade" Width="30%" CssClass="form-control" />
        <asp:RequiredFieldValidator
            ID="requiredIdade"
            runat="server"
            ControlToValidate="txtIdade"
            ErrorMessage="Por favor, digite sua Idade."
            ForeColor="Red"
            />
            <br />

        Objetivo_Graduacao: <br />
        <asp:TextBox ID="txtObjetivo_Graduacao" runat="server" placeholder="Seu Objetivo" Width="30%" CssClass="form-control" />
        <asp:RequiredFieldValidator
            ID="requiredObjetivo_Graduacao"
            runat="server"
            ControlToValidate="txtObjetivo_Graduacao"
            ErrorMessage="Por favor, digite seu Objetivo."
            ForeColor="Red"
            />
            <br />

        Genero: <br />
        <asp:TextBox ID="txtGenero" runat="server" placeholder="Seu Genero" Width="20%" CssClass="form-control" />
        <asp:RequiredFieldValidator
            ID="requiredGenero"
            runat="server"
            ControlToValidate="txtGenero"
            ErrorMessage="Por favor, digite seu Genero."
            ForeColor="Red"
            />
            <br />

            <p> 
                <asp:Label ID="lblMensagem" runat="server" />                           
            </p>

            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastroAluno"/>
            <a href="/Default.aspx" class="btn btn-defaut btn-lg">Voltar</a>
       
    </form>
</body>
</html>