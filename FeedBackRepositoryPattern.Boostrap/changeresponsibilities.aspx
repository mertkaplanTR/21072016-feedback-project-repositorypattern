<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changeresponsibilities.aspx.cs" Inherits="FeedBackRepositoryPattern.Boostrap.changeresponsibilities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

            <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>Hata Bildirim Giriş ve Kayıt Sayfası</title>

        <!-- CSS -->
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css">
		<link rel="stylesheet" href="assets/css/form-elements.css">
        <link rel="stylesheet" href="assets/css/style.css">

        <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
            <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->

        <!-- Favicon and touch icons -->
        <link rel="shortcut icon" href="assets/ico/favicon.png">
        <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/apple-touch-icon-144-precomposed.png">
        <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/apple-touch-icon-114-precomposed.png">
        <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/apple-touch-icon-72-precomposed.png">
        <link rel="apple-touch-icon-precomposed" href="assets/ico/apple-touch-icon-57-precomposed.png">
</head>
<body>
    <form id="form1" runat="server">
         <div class="top-content">

                    <div class="inner-bg">
                        <div class="container">
                            <div class="row">
                                 <asp:GridView ID="grdProgrammersProjects" runat="server" CssClass="table table-striped table-bordered table-hover table-responsive table-condensed"></asp:GridView>
                               <div class="col-sm-8 col-sm-offset-2 text">
                                   <h1><strong>Proje Atama</strong> </br><%--&amp;--%>Proje Değiştirme Sayfası</h1>
                               </div>
                             </div>
                          </div>
                        </div>

             <div class="col-sm-6">
                    <div class="row">
                        <div class="form-group">

				          
                            <h3><strong>Programmer Seçiniz</strong><br />
                           <asp:DropDownList ID="ddlProgammers" runat="server" CssClass="btn btn-primary dropdown-toggle" AppendDataBoundItems="true"></asp:DropDownList>
				        </div>
                    </div>
              </div>
              
                      <div class="col-sm-6">
                    <div class="row">
                        <div class="form-group">

				           
                            <h3><strong>Proje Seçiniz</strong><br />
                           <asp:DropDownList ID="ddlProjects" runat="server" CssClass="btn btn-primary dropdown-toggle" AppendDataBoundItems="true"></asp:DropDownList>
				        </div>
                        </br>
                       
                        <asp:Button ID="btnSaveProgrammerToProject" runat="server" CssClass="btn btn-primary" Text="Kaydet" OnClick="btnSaveProgrammerToProject_Click"/>
                    </div>
              </div>
         
         
         </div>

           <!-- Javascript -->
        <script src="assets/js/jquery-1.11.1.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.backstretch.min.js"></script>
        <script src="assets/js/scripts.js"></script>
    </form>
</body>
</html>
