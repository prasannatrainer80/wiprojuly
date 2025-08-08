package com.java.demo;

import java.util.Comparator;
import java.util.SortedSet;
import java.util.TreeSet;

public class SortEmploy {

	public static void main(String[] args) {
//		Comparator c = new NameComparator();
		Comparator c = new BasicComparator();
		SortedSet employs = new TreeSet(c);
		employs.add(new Employ(1, "Vijay", 99323));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(5, "Hemanth", 90032));
		employs.add(new Employ(6, "Bhavana", 98883));
		employs.add(new Employ(7, "Surya", 97724));
		System.out.println("Sorted Records are  ");
		for (Object object : employs) {
			System.out.println(object);
		}
		
	}
}
