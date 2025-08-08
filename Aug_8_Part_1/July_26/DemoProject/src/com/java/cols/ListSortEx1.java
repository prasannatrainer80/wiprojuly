package com.java.cols;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class ListSortEx1 {

	public static void main(String[] args) {
		List names = new ArrayList();
		names.add("Srinivas");
		names.add("Pavan");
		names.add("Rajitha");
		names.add("Teja");
		names.add("Aishwarya");
		
		for (Object object : names) {
			System.out.println(object);
		}
		
		names.add(2, "Bhaveen");
		
		System.out.println("Data after adding new Value");
		for (Object object : names) {
			System.out.println(object);
		}
		names.set(3, "Hyma");
		System.out.println("Data After Updating Value   ");
		for (Object object : names) {
			System.out.println(object);
		}
		
		names.remove("Aishwarya");
		System.out.println("Data after removing   ");
		for (Object object : names) {
			System.out.println(object);
		}

		Collections.sort(names);
		System.out.println("List after Sorting...");
		for (Object object : names) {
			System.out.println(object);
		}
	}
}
