package com.java.demo;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class UserAuth {

	public static void main(String[] args) {
		Map map = new HashMap();
		map.put("Hyma","Chaganti");
		map.put("Ammar","Hussain");
		map.put("Bhaveen","Balapalli");
		map.put("Ashwini","Gaddam");
		map.put("Uday","Kumar");
		String user, pwd;
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter UserName   ");
		user = sc.next();
		System.out.println("Enter Password   ");
		pwd = sc.next();
		String res = (String) map.getOrDefault(user, "Not Found");
		if (pwd.equals(res)) {
			System.out.println("Correct Credentials...");
		} else {
			System.out.println("Invalid Credentials...");
		}
	}
}
