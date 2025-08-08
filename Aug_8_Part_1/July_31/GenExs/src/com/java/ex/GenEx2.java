package com.java.ex;

import java.util.ArrayList;
import java.util.List;

public class GenEx2 {

	public static void main(String[] args) {
		List<?> lt=new ArrayList<>();
		((ArrayList<Integer>) lt).add(new Integer(42));
		((ArrayList<String>) lt).add(new String("Nagaraju"));
		((ArrayList<Double>) lt).add(new Double(423.44));
		((ArrayList<Boolean>) lt).add(new Boolean(true));
		
		for (Object object : lt) {
			System.out.println(object);
		}

	}
}
