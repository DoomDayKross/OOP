package business;

import java.io.Serializable;
import java.util.*;
import jakarta.persistence.*;

public class Cart implements Serializable
{
	private String cartCode;
	private ArrayList<LineItem> items;
	private User user;
	
	public Cart()
	{
		items = new ArrayList<LineItem>();
		user = new User();
	}

	public Cart(ArrayList<LineItem> items, User user, String cartCode) 
	{
		this.items = items;
		this.user = user;
		this.cartCode = cartCode;
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
	
	public String getCartCode() 
	{
		return cartCode;
	}

	public void setCartCode(String cartCode) 
	{
		this.cartCode = cartCode;
	}

	public int getCount()
	{
		return items.size();
	}
	
	public void addItem(LineItem item)
	{
		String code = item.getItem().getProductCode();
        int quantity = item.getQuantity();
        for (int i = 0; i < items.size(); i++) {
            LineItem lineItem = items.get(i);
            if (lineItem.getItem().getProductCode().equals(code)) {
                lineItem.setQuantity(quantity);
                return;
            }
        }
        items.add(item);
	}
	
	public void removeItem(LineItem item)
	{
		String code = item.getItem().getProductCode();
        for (int i = 0; i < items.size(); i++) {
            LineItem lineItem = items.get(i);
            if (lineItem.getItem().getProductCode().equals(code)) {
                items.remove(i);
                return;
            }
        }
	}
}
