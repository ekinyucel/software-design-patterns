package observable;

import java.util.HashSet;
import java.util.Observable;

import product.Product;

public class AuctioneerImpl extends Observable implements Auctioneer {
	public void news(HashSet<Product> goods) {
		for (Product good : goods) {
			setChanged();
			notifyObservers(good);
			try {
				Thread.sleep(1000);
			} catch (Exception e) {
				System.out.println("Error occurred " + e);
			}
		}
	}
}