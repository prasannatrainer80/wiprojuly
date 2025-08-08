package com.java.ex;

import java.util.Comparator;

public class BasicComparator implements Comparator<Employ> {

	@Override
	public int compare(Employ e1, Employ e2) {
		if (e1.getBasic() >= e2.getBasic()) {
			return 1;
		}
		return -1;
	}

}
