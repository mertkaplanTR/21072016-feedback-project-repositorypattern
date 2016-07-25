<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="WebApplicationzzzzz.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Admin Login</title>
   <!-- /.website title -->

<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">

<!-- CSS Files -->
<link href="css/bootstrap.min.css" rel="stylesheet" media="screen">
<link href="css/font-awesome.min.css" rel="stylesheet">
<link href="fonts/icon-7-stroke/css/pe-icon-7-stroke.css" rel="stylesheet">
<link href="css/animate.css" rel="stylesheet" media="screen">
<link href="css/owl.theme.css" rel="stylesheet">
<link href="css/owl.carousel.css" rel="stylesheet">

<!-- Colors -->
<link href="css/css-index.css" rel="stylesheet" media="screen">
<!-- <link href="css/css-index-green.css" rel="stylesheet" media="screen"> -->
<!-- <link href="css/css-index-purple.css" rel="stylesheet" media="screen"> -->
<!-- <link href="css/css-index-red.css" rel="stylesheet" media="screen"> -->
<!-- <link href="css/css-index-orange.css" rel="stylesheet" media="screen"> -->
<!-- <link href="css/css-index-yellow.css" rel="stylesheet" media="screen"> -->

<!-- Google Fonts -->
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,100italic,300italic,400italic,700italic,900italic" />
</head>


<body>
    <form id="form1" runat="server">

<%--<!-- /.preloader -->
<div id="preloader"></div>
<div id="top"></div>--%>

        <div id="menu">
	<nav class="navbar-wrapper navbar-default" role="navigation">
		<div class="container">
			  <div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-backyard">
				  <span class="sr-only">Toggle navigation</span>
				  <span class="icon-bar"></span>
				  <span class="icon-bar"></span>
				  <span class="icon-bar"></span>
				</button>
				<a class="navbar-brand site-name" href="#top"><img src="images/logo2.png" alt="logo"></a>
			  </div>
	 
			  <div id="navbar-scroll" class="collapse navbar-collapse navbar-backyard navbar-right">
				<ul class="nav navbar-nav">
					<li><a href="#intro">About</a></li>
					<li><a href="#feature">Features</a></li>
					<li><a href="#download">Download</a></li>
					<li><a href="#package">Pricing</a></li>
					<li><a href="#testi">Reviews</a></li>
					<li><a href="#contact">Contact</a></li>
				</ul>
			  </div>
		</div>
	</nav>
</div>

        <!-- /.parallax full screen background image -->
<div class="fullscreen landing parallax" style="background-image:url('images/bg2.jpg');" data-img-width="2000" data-img-height="1333" data-diff="100">
	
	<div class="overlay">
		<div class="container">
			<div class="row">
				<div class="col-md-12">
				
					<!-- /.logo -->
					<div class="logo wow fadeInDown"></a>
					<!-- /.main title -->
						<h1 class="wow fadeInLeft">
					<center>Admin Login</center>
						</h1>
                        	<div class="form-group">
							</div>
                    <div class="signup-header wow fadeInUp">
							<div class="form-group">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txtAdminUsername" runat="server" CssClass="form-control input-lg" type="text" placeholder="Your Username"/> </asp:TextBox>
                            <div class="form-group">
							</div>
                                 <asp:TextBox ID="txtAdminPassword" runat="server" CssClass="form-control input-lg" type="text" placeholder="Your Password"/> </asp:TextBox>
							<div class="form-group">
							</div>
                             <div class="form-group">
							</div>
							<div class="form-group last">
                                <asp:Button ID="btnAdminLogin" runat="server" CssClass="btn btn-info btn-block btn-lg" text="Login" OnClick="btnAdminLogin_Click"/>
							</div>
							<p class="privacy text-center">Forget Password? <a href="privacy.html">Click</a></p>
					</div>	
				    </div> 
		    	</div>
		    </div> 
	</div> 
</div>


















    </form>




</body>
</html>
