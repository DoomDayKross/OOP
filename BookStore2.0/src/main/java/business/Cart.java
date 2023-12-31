package business;

import java.io.Serializable;
import java.util.*;
import jakarta.persistence.*;

@Entity
public class Cart implements Serializable 
{
	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private long cartId;

	@OneToMany(cascade = CascadeType.ALL, orphanRemoval = true)
	private ArrayList<LineItem> items;
	
	@OneToOne
	@JoinColumn(name = "userID")
	private User user;
	
	public Cart()
	{
		items = new ArrayList<LineItem>();
		user = new User();
	}

	public Cart(ArrayList<LineItem> items, User user) 
	{
		this.items = items;
		this.user = user;
	}
	public long getCartId() {
		return cartId;
	}

	public void setCartId(long cartId) {
		this.cartId = cartId;
	}
		
	public ArrayList<LineItem> getLineItems() 
	{
		return items;
	}

	public void setLineItems(ArrayList<LineItem> items) 
	{
		this.items = items;
	}

	public User getUser() 
	{
		return user;
	}

	public void setUser(User user) 
	{
		this.user = user;
	}

	public int getCount()
	{
		return items.size();
	}
	
	public void addItem(LineItem item)
	{
		
	}
	
	public void removeItem(LineItem item)
	{
		
	}
}
