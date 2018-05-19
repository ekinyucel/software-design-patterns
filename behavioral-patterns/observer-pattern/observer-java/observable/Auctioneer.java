package observable;

import java.util.HashSet;

import product.Product;

public interface Auctioneer {
	public void news(HashSet<Product> goods);
}
