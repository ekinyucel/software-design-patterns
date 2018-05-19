package main;

import java.util.HashSet;

import observable.AuctioneerImpl;
import observer.Bidder;
import observer.BidderImpl;
import product.Product;
import product.ProductImpl;

public class Main {

	public static void main(String[] args) {
		Product painting = new ProductImpl(1, "Mona Lisa Painting", 100000);
		Product artifact = new ProductImpl(2, "The Ottoman Artifact", 50000);

		HashSet<Product> goods = new HashSet<Product>();
		goods.add(painting);
		goods.add(artifact);

		AuctioneerImpl auctioneer1 = new AuctioneerImpl();
		
		Bidder bidder1 = new BidderImpl(1, "bidder1");
		Bidder bidder2 = new BidderImpl(2, "bidder2");

		HashSet<Bidder> bidders = new HashSet<Bidder>();		
		bidders.add(bidder1);
		bidders.add(bidder2);
		
		for(Bidder bidder : bidders) {
			auctioneer1.addObserver(bidder);
		}
		
		auctioneer1.news(goods);
	}

}
