package com.java.ex;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class GenListSort {

	public static void main(String[] args) {
		List<Employ> employList = new ArrayList<Employ>();
		employList.add(new Employ(1, "Ashwini", "Java", "Programmer", 99423.44));
		employList.add(new Employ(2, "Bhaveen", "Dotnet", "Developer", 99255.44));
		employList.add(new Employ(3, "Teja", "Sql", "Manager", 88323.44));
		employList.add(new Employ(4, "Ammar", "React", "Expert", 80993.44));
		employList.add(new Employ(5, "Nagaraju", "Java", "Tester", 90344.44));
		employList.add(new Employ(6, "Vinod", "Sql", "Developer", 89093.44));
		System.out.println("Employ List   ");
		for (Employ employ : employList) {
			System.out.println(employ);
		}
//		Collections.sort(employList);
	}
}
