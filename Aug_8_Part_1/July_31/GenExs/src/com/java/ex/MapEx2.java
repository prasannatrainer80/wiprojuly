package com.java.ex;

import java.util.Hashtable;
import java.util.Map;
import java.util.Scanner;

public class MapEx2 {

	public static void main(String[] args) {
		Map<String, String> userData = new Hashtable<String, String>();
		userData.put("Nagaraju", "Lonka");
		userData.put("Surya", "Routhula");
		userData.put("Ashwini", "Gaddam");
		userData.put("Ammar", "Husain");
		userData.put("Srinu", "Ramisetti");
		userData.put("Pavan", "Jani");
		
		String user, pwd;
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter UserName and Password   ");
		user = sc.next();
		pwd = sc.next();
		String res = userData.getOrDefault(user, "Not Found");
		if (res.equals(pwd)) {
			System.out.println("Correct Credentials...");
		} else {
			System.out.println("Invalid Credentials...");
		}
	}
}
