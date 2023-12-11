package business;

import java.io.Serializable;
import jakarta.persistence.*;

@Entity
public class LineItem implements Serializable
{
	private long itemId;
	private String itemCode;
	private int quantity;
	private Product product;
	private double discount;
	
	public LineItem()
	{
		quantity = 0;
		product = new Product();
		discount = 0;
	}

	public LineItem(int quantity, Product product, double discount) 
	{
		this.quantity = quantity;
		this.product = product;
		this.discount = discount;
		itemCode = this.product.getProductCode();
	}

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	public long getItemId() 
	{
		return itemId;
	}

	public void setItemId(long itemId) 
	{
		this.itemId = itemId;
	}

	public String getItemCode() 
	{
		return itemCode;
	}

	public void setItemCode(String itemCode) 
	{
		this.itemCode = itemCode;
	}

	public int getQuantity() 
	{
		return quantity;
	}

	public void setQuantity(int quantity) 
	{
		this.quantity = quantity;
	}

	public Product getItem() 
	{
		return product;
	}

	public void setItem(Product product) 
	{
		this.product = product;
	}

	public double getDiscount() 
	{
		return discount;
	}

	public void setDiscount(double discount) 
	{
		this.discount = discount;
	}
	
	public double getTotal()
	{
		return 0;
	}
	
	public String getTotalCurrencyFormat()
	{
		return "";
	}
}
