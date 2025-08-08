package com.java.ex;

import java.util.Hashtable;
import java.util.Map;
import java.util.Map.Entry;

public class MapEx1 {

	public static void main(String[] args) {
		Map<String, Double> map1 = new Hashtable<String, Double>();
		map1.put("Bhaveen", 99423.44);
		map1.put("Ammar", 90042.44);
		map1.put("Aishwarya", 89942.44);
		map1.put("Lakshmi", 99423.44);
		map1.put("Naveen", 99423.44);
		
		for(Entry<String,Double> m : map1.entrySet()) {
			System.out.println(m.getKey() + "  " +m.getValue());
		}
	}
}
