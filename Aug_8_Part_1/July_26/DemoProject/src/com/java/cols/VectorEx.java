package com.java.cols;

import java.util.Vector;

public class VectorEx {

	public static void main(String[] args) {
		Vector vector = new Vector(3,2);
		System.out.println("Vector Size  " +vector.size());
		System.out.println("Capacity  " +vector.capacity());
		vector.addElement("Ammar");
		vector.addElement("Neha");
		System.out.println("Vector Size  " +vector.size());
		System.out.println("Capacity  " +vector.capacity());
		vector.addElement("Tharun");
		System.out.println("Vector Size  " +vector.size());
		System.out.println("Capacity  " +vector.capacity());
		vector.addElement("Pavan");
		System.out.println("Vector Size  " +vector.size());
		System.out.println("Capacity  " +vector.capacity());


		
	}
}
