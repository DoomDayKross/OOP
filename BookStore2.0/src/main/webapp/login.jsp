<!DOCTYPE html>
<%@ taglib prefix="c" uri="jakarta.tags.core" %>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<title>Book Store</title>
	<link rel="stylesheet" href="style.css">
	<link rel="preconnect" href="https://fonts.googleapis.com">
	<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
	<link href="https://fonts.googleapis.com/css2?family=Kdam+Thmor+Pro&display=swap" rel="stylesheet">
	<link rel="stylesheet"
		href="https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@6.4.2/css/fontawesome.min.css"
		integrity="sha384-BY+fdrpOd3gfeRvTSMT+VUZmA728cfF9Z2G42xpaRkUGu2i3DyzpTURDo5A6CaLK" crossorigin="anonymous">
</head>

<body>
	<div class="header">
		<div class="container">
			<div class="navbar">
				<div class="logo">
					<img src="images/pngLogo.png" width="125px">
				</div>
				<nav>
					<ul>
						<li><a href="index.jsp">Home</a></li>
						<li><a href="products.jsp">Products</a></li>
						<li><a href="">About Us</a></li>
						<li><a href="">Contact</a></li>
						<li><a href="login.jsp">Account</a></li>
					</ul>
				</nav>
				<img src="images/favpng_font-awesome-shopping-cart-font.png" width="30px" height="30px">
			</div>
		</div>
	</div>

	<div class="account-page">
		<div class="container">
			<div class="row">
				<div class="col-2">
					<img src="images/logo.png" width="10%">
				</div>

				<div class="col-2">
					<div class="form-container">
						<div class="form-btn">
							<span onclick="login()">Login</span>
							<span onclick="register()">Register</span>
							<hr id="Indicator">
						</div>

						<form id="LoginForm">
							<input type="email" placeholder="Email">
							<input type="password" placeholder="Password">
							<button type="submit" class="btn">Login</button>
							<a href="">Forget Password</a>
						</form>

						<form id="RegisterForm">
							<input type="email" placeholder="Email">
							<input type="password" placeholder="Password">
							<button type="submit" class="btn">Register</button>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- js toggle menu -->
	<script>
		var LoginForm = document.getElementById("LoginForm");
		var RegisterForm = document.getElementById("RegisterForm");
		var Indicator = document.getElementById("Indicator");
		function register() {
			RegisterForm.style.transform = "translateX(0px)";
			LoginForm.style.transform = "translateX(0px)";
			Indicator.style.transform = "translateX(100px)";
		}

		function login() {
			RegisterForm.style.transform = "translateX(300px)";
			LoginForm.style.transform = "translateX(300px)";
			Indicator.style.transform = "translateX(0px)";
		}

	</script>


</body>

</html>