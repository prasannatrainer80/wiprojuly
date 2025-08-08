package com.java.demo;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

public class MapEx2 {

	public static void main(String[] args) {
		Map map = new HashMap();
		map.put("John", 25);
		map.put("Jane", 30);
		map.put("David", 35);

		// Iterating over keys using for-each loop
		for (Object key : map.keySet()) {
		    Object value = map.get(key);
		    System.out.println(key + " : " + value);
		}
		// Iterating over keys using iterator
		Iterator iterator = map.keySet().iterator();
		while (iterator.hasNext()) {
		    Object key = iterator.next();
		    Object value = map.get(key);
		    System.out.println(key + " : " + value);
		}
	}
}
