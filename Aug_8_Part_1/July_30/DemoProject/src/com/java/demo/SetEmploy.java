package com.java.demo;

import java.util.HashSet;
import java.util.Set;

public class SetEmploy {

	public static void main(String[] args) {
		Set employs = new HashSet();
		employs.add(new Employ(1, "Vijay", 99323));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(5, "Hemanth", 90032));
		employs.add(new Employ(6, "Bhavana", 98883));
		employs.add(new Employ(7, "Surya", 97724));
		employs.add(new Employ(1, "Vijay", 99323));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(1, "Vijay", 99323));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(5, "Hemanth", 90032));
		employs.add(new Employ(6, "Bhavana", 98883));
		employs.add(new Employ(7, "Surya", 97724));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(5, "Hemanth", 90032));
		employs.add(new Employ(6, "Bhavana", 98883));
		employs.add(new Employ(7, "Surya", 97724));
		employs.add(new Employ(2, "Tharun", 99442));
		employs.add(new Employ(3, "Ammar", 88822));
		employs.add(new Employ(4, "Vinod", 99922));
		employs.add(new Employ(5, "Hemanth", 90032));
		employs.add(new Employ(6, "Bhavana", 98883));
		employs.add(new Employ(7, "Surya", 97724));
		System.out.println("Employ Records are  ");
		for (Object object : employs) {
			Employ employ = (Employ)object;
			System.out.println(employ);
		}
	}
}
