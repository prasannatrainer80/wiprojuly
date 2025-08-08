package com.java.ex;

import java.util.ArrayList;
import java.util.List;

public class GenListEx1 {

	public static void main(String[] args) {
		List<String> names = new ArrayList<String>();
		names.add("Sreenivas");
		names.add("Nagaraju");
		names.add("Vinod");
		names.add("Padma");
		names.add("Ashwini");
	//	names.add(12);
		System.out.println("Names are  ");
		for (String string : names) {
			System.out.println(string);
		}
	}
}
