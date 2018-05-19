package product;

public abstract class Product {
	private int ID;
	private String name;
	private double price;

	public Product(int ID, String name, double price) {
		this.ID = ID;
		this.name = name;
		this.price = price;
	}

	public int getID() {
		return ID;
	}

	public void setID(int iD) {
		ID = iD;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
}
