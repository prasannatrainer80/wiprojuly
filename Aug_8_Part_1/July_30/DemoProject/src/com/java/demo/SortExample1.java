package com.java.demo;

import java.util.SortedSet;
import java.util.TreeSet;

public class SortExample1 {

	public static void main(String[] args) {
		SortedSet names = new TreeSet();
		names.add("Rajitha");
		names.add("Padma");
		names.add("Bhaveen");
		names.add("Neha");
		names.add("Dinesh");
		names.add("Ashwini");
		names.add("Ammar");
		names.add("Vinod");
		
		for (Object object : names) {
			System.out.println(object);
		}
	}
}
