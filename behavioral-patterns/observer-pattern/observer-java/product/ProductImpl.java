package product;

public class ProductImpl extends Product {

	public ProductImpl(int ID, String name, double price) {
		super(ID, name, price);
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null)
			return false;
		if (!(obj instanceof Product))
			return false;
		if (obj == this)
			return true;

		return this.getID() == ((Product) obj).getID();
	}

	@Override
	public int hashCode() {
		return getID();
	}

}
