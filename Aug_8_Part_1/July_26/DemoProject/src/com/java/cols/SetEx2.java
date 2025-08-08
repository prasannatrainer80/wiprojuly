package com.java.cols;

import java.util.LinkedHashSet;
import java.util.Set;

public class SetEx2 {

	public static void main(String[] args) {
		Set names = new LinkedHashSet();
		names.add("Pavan");
		names.add("Vinod");
		names.add("Hyma");
		names.add("Aishwarya");
		names.add("Hemanth");
		names.add("Krishna");
		names.add("Pavan");
		names.add("Vinod");
		names.add("Hyma");
		names.add("Aishwarya");
		names.add("Hemanth");
		names.add("Pavan");
		names.add("Vinod");
		names.add("Hyma");
		names.add("Aishwarya");
		names.add("Hemanth");
		names.add("Vinod");
		names.add("Hyma");
		names.add("Aishwarya");
		names.add("Hemanth");
		names.add("Krishna");
		names.add("Vinod");
		names.add("Hyma");
		names.add("Aishwarya");
		names.add("Hemanth");
		names.add("Krishna");
		
		System.out.println("HashSet Data is ");
		for (Object object : names) {
			System.out.println(object);
		}
	}
}
