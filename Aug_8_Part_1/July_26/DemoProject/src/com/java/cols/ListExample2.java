package com.java.cols;

import java.util.ArrayList;
import java.util.List;

public class ListExample2 {

	public static void main(String[] args) {
		List listData = new ArrayList();
		listData.add(new Integer(42));
		listData.add(new Integer(13));
		listData.add(new Integer(21));
		listData.add(new Integer(90));
		listData.add(new Integer(67));
		
		int sum = 0;
		for (Object object : listData) {
			Integer i = (Integer)object;
			sum += i;
		}
		System.out.println("Sum is  " +sum);
	}
}
