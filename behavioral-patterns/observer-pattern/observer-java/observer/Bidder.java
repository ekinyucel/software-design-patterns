package observer;

import java.util.Observable;
import java.util.Observer;

public abstract class Bidder implements Observer {
	private int ID;
	private String name;

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

	public Bidder(int ID, String name) {
		this.ID = ID;
		this.name = name;
	}

	public abstract void update(Observable o, Object arg);	
}
