package com.java.cols;

import java.util.ArrayList;
import java.util.List;

public class ListExample3 {

	public static void main(String[] args) {
		List employList = new ArrayList();
		employList.add(new Employ(1, "Aishwarya", 62334.22));
		employList.add(new Employ(2, "Teja", 90042.22));
		employList.add(new Employ(3, "Bhaveen", 90042.22));
		employList.add(new Employ(4, "Rajitha", 88832.22));
		employList.add(new Employ(5, "Nagaraju", 91165.22));
		System.out.println("Employ List   ");
		for (Object object : employList) {
			Employ employ = (Employ)object;
			System.out.println(employ);
		}
		
	}
}
