<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de Aluno</title>
    <link type="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.mim.js"></script>
<body>
    <img src="https://imagizer.imageshack.com/img923/8149/e7paML.jpg " class="well" width="400" height="200"/>
   <form id="form1" runat="server">
    <div class="container" style="background-color:red">
        <div class="row">

    </div></div>
       <h3 class="well">Consulta de Aluno</h3>
       <asp:GridView ID="gridUsuario" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccccff">
           <Columns>
               <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
               <asp:BoundField DataField="Nome" HeaderText="Nome" />
               <asp:BoundField DataField="Data_Nasc" HeaderText="Data_Nasc" />
               <asp:BoundField DataField="Idade" HeaderText="Idade" />
               <asp:BoundField DataField="Objetivo_Graduacao" HeaderText="Objetivo_Graduacao" />
               <asp:BoundField DataField="Genero" HeaderText="Genero" />
               
           </Columns>
           <RowStyle CssClass="cursor-pointer" />
       </asp:GridView>

       <p>
           <asp:Label ID="lblMensagem" runat="server"/>
       </p>

       <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
             
    </form>
</body>
</html>
