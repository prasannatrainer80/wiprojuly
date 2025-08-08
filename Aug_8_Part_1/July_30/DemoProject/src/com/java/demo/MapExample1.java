package com.java.demo;

import java.util.HashMap;
import java.util.Map;
import java.util.Map.Entry;

public class MapExample1 {

	public static void main(String[] args) {
		Map map = new HashMap();
		map.put("Hyma","Chaganti");
		map.put("Ammar","Hussain");
		map.put("Bhaveen","Balapalli");
		map.put("Ashwini","Gaddam");
		map.put("Uday","Kumar");

		System.out.println("Map Iteration Values...");
		for(Object ob : map.keySet()) {
			System.out.println(ob + "  " +map.get(ob));
		}
	}
}
