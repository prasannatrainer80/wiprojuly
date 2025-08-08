package com.java.cols;

import java.util.LinkedList;

public class LinkedListEx1 {

	public static void main(String[] args) {
		LinkedList list1 = new LinkedList();
		list1.add("Bhavana");
		list1.add("Surya");
		
		list1.add("Uday");
		list1.add("Krishna");
		list1.add("Harshitha");
		list1.add("Ammar");
		list1.addFirst("Vijay");
		list1.addLast("Tharun");
		System.out.println("Linked List Data  ");
		for (Object object : list1) {
			System.out.println(object);
		}
	}
}
