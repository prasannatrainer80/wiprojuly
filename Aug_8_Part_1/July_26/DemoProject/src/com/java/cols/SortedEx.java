package com.java.cols;

import java.util.SortedSet;
import java.util.TreeSet;

public class SortedEx {

	public static void main(String[] args) {
		SortedSet names = new TreeSet();
		names.add("Srinivas");
		names.add("Pavan");
		names.add("Rajitha");
		names.add("Teja");
		names.add("Aishwarya");
		names.add("Nagaraj");
		names.add("Ashwini");
		
		System.out.println("Sorted Data  ");
		for (Object object : names) {
			System.out.println(object);
		}
	}
}
