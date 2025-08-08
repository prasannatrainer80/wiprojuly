package com.java.demo;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

public class MapEx1 {

	public static void main(String[] args) {
		Map<String, Integer> map = new HashMap<>();
		map.put("John", 25);
		map.put("Jane", 30);
		map.put("David", 35);

		// Iterating over keys using for-each loop
		for (String key : map.keySet()) {
		    Integer value = map.get(key);
		    System.out.println(key + " : " + value);
		}
		// Iterating over keys using iterator
		Iterator<String> iterator = map.keySet().iterator();
		while (iterator.hasNext()) {
		    String key = iterator.next();
		    Integer value = map.get(key);
		    System.out.println(key + " : " + value);
		}
	}
}
