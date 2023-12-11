<%@ taglib prefix="c" uri="jakarta.tags.core" %>
<%@ include file="/includes/header.jsp" %>
<p>${message}</p>
<div class="small-container single-product">
	<div class="row">
		<div class="col2">
			<img src="images/${product.getProductCode()}.jpg" width=100% id="ProductImg">
		</div>
		<div class="col2">
			<h1>${product.getInfor().getBookName()}</h1>
			<h4>${product.getCurrencyFormat()}</h4>
			<form action="cart" method="post">
				<input type="hidden" name="action" value="add">
				<input type="hidden" name="productCode" value="${product.getProductCode()}">
				<input type="hidden" name="addQuantity" value="1">
				<button type="submit">Add to cart</button>
			</form>
			<h3>Product Details</h3>
			<p>${product.getInfor().getDetail()}</p>
		</div>
	</div>
</div>

<div class="small-container">
	<h2 class="title">Related Products</h2>
</div>

<div class="row">
	<div class="col4">
		<img src="images/countofmontecristo.jpg">
		<h4>The Count of Monte Cristo</h4>
		<p>523.000 VND</p>
	</div>
	<div class="col4">
		<img src="images/bloodthristy.jpg">
		<h4>Bloodthirsty</h4>
		<p>335.000 VND</p>
	</div>
	<div class="col4">
		<img src="images/themissingqueen.jpg">
		<h4>The Missing Queen</h4>
		<p>452.000 VND</p>
	</div>
	<div class="col4">
		<img src="images/excuseme.jpg">
		<h4>Excuse Me While I Disappear</h4>
		<p>226.000 VND</p>
	</div>
</div>
<%@ include file="/includes/footer.jsp" %>