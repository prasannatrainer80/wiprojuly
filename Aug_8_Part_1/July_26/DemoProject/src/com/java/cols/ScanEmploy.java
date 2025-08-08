package com.java.cols;

import java.util.Scanner;

public class ScanEmploy {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		Employ employ = new Employ();
		System.out.println("Enter Employ No  ");
		employ.setEmpno(sc.nextInt());
		System.out.println("Enter Employ Name  ");
		employ.setName(sc.next());
		System.out.println("Enter Basic   ");
		employ.setBasic(sc.nextDouble());
		
		System.out.println("Employ No  " +employ.getEmpno());
		System.out.println("Employ Name  " +employ.getName());
		System.out.println("Basic   " +employ.getBasic());
	}
}
