<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FeedBackRepositoryPattern.Boostrap.login" %>

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
                        <div class="col-sm-8 col-sm-offset-2 text">
                            <h1><strong>Login & Reporting</strong></h1>
                            <%--<div class="description">
                            	<p>
	                            	This is a free responsive <strong>"login and register forms"</strong> template made with Bootstrap. 
	                            	Download it on <a href="http://azmind.com" target="_blank"><strong>AZMIND</strong></a>, 
	                            	customize and use it as you like!
                            	</p>
                            </div>--%>
                        </div>
                    </div>
                    
                    <div class="row">
                      
                           <div class="col-sm-5">
                        	
                        	<div class="form-box">
	                        	<div class="form-top">
	                        		<div class="form-top-left">
	                        			<h3>Admin Login Area</h3>
	                            		<p>Enter username and password to log on:</p>
	                        		</div>
	                        		<div class="form-top-right">
	                        			<i class="fa fa-lock"></i>
	                        		</div>
	                            </div>
	                            <div class="form-bottom">
				                    <form role="form" action="" method="post" class="login-form">
				                    	<div class="form-group">
				                    		<label class="sr-only" for="form-username">Username</label>
				                        	<asp:TextBox ID="txtUsername" runat="server"  placeholder="Username" class="form-password form-control" required></asp:TextBox>
				                        </div>
				                        <div class="form-group">
				                        	<label class="sr-only" for="form-password">Password</label>
                                            <asp:TextBox ID="txtPassword" runat="server"  placeholder="Password" class="form-password form-control" type="password" required></asp:TextBox>
				                        </div>
                                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary"  />
				                        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
				                    </form>
			                    </div>
		                    </div>
                        </div>
                        
                        <div class="col-sm-1 middle-border"></div>
                        <div class="col-sm-1"></div>
                        	

                       <%-- Aşağıdaki kısım commentlenen çalışıyor sorun yok, sağ taraf tasarımdaki--%>
                        <div class="col-sm-5">
                        	
                        	<div class="form-box">
                        		<div class="form-top">
	                        		<div class="form-top-left">
	                        			<h3>Report Us Now</h3>
	                            		<p>Fill in the form below to report your project</p>
	                        		</div>
	                        		<div class="form-top-right">
	                        			<i class="fa fa-pencil"></i>
	                        		</div>
	                            </div>
	                            <div class="form-bottom">
				                   
				                    	<div class="form-group">
				                    		<label class="sr-only" for="form-first-name">Full Name Label</label>
                                            <asp:TextBox ID="txtFullName" runat="server" placeholder="Full Name" CssClass="form-first-name form-control" type="text" required></asp:TextBox>
				                        </div>
				                        <div class="form-group">
				                        	<label class="sr-only" for="form-last-name">Company Name Label</label>
				                        	<asp:TextBox ID="txtCompany" runat="server" placeholder="Company Name" CssClass="form-first-name form-control" type="text" required></asp:TextBox>
				                        </div>
				                        <div class="form-group">
				                        	<label class="sr-only" for="form-email">Email</label>
                                            <asp:TextBox ID="txtEmail" type="email" runat="server" placeholder="Email Address" CssClass="form-email form-control" required></asp:TextBox>
				                        </div>

                                     <div class="form-group">
				                        	<label class="sr-only" for="form-about-yourself">Tell About Problem</label>
                                            <asp:TextBox ID="txtContactNumber" runat="server" placeholder="Contact Number" CssClass="form-about-yourself form-control"></asp:TextBox>
			                        </div>

                                        <div class="form-group">
				                        	<label class="sr-only" for="form-email">Email</label>
                                            <asp:DropDownList ID="ddlProjects" runat="server" placeholder="Proje Seçiniz" CssClass="btn btn-primary dropdown-toggle" AppendDataBoundItems="true"></asp:DropDownList>
				                        </div>

                                     <div class="form-group">
				                        	<label class="sr-only" for="form-about-yourself">Tell About Problem</label>
                                            <asp:TextBox ID="txtSubject" runat="server" placeholder="Subject" CssClass="form-about-yourself form-control"></asp:TextBox>
			                        </div>


				                        <div class="form-group">
				                        	<label class="sr-only" for="form-about-yourself">Tell About Problem</label>
                                            <asp:TextBox ID="txtProblem" runat="server" placeholder="Tell about problem" CssClass="form-about-yourself form-control"></asp:TextBox>
			                        </div>

                                        <asp:Button ID="btnSendReport" runat="server" CssClass="btn btn-primary" Text="Gönder" OnClick="btnSendReport_Click" />
			                    </div>
                        	</div>
                        <asp:GridView ID="grdProgrammersProjects" runat="server" CssClass="table table-striped table-bordered table-hover table-responsive table-condensed"></asp:GridView>
                        </div>

           <!-- Javascript -->
        <script src="assets/js/jquery-1.11.1.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.backstretch.min.js"></script>
        <script src="assets/js/scripts.js"></script>
    </form>
</body>
</html>
