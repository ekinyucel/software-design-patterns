package observer;

import java.util.Observable;

import product.Product;

public class BidderImpl extends Bidder {

	public BidderImpl(int ID, String name) {
		super(ID, name);
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null)
			return false;
		if (!(obj instanceof Bidder))
			return false;
		if (obj == this)
			return true;
		return this.getID() == ((Bidder) obj).getID();
	}

	@Override
	public int hashCode() {
		return getID();
	}

	@Override
	public void update(Observable o, Object arg) {
		if (arg instanceof Product && arg != null) {
			System.out.println(this.getName() + " learns the newest product: " + ((Product) arg).getName());
		}

	}
}
