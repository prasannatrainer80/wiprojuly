package com.java.cols;

public class Prog1 {

	public static void main(String[] args) {
		Employ employ = new Employ();
		employ.setEmpno(1);
		employ.setName("Rajitha");
		employ.setBasic(99323.44);
		
		System.out.println("Employ No  " +employ.getEmpno());
		System.out.println("Employ Name   " +employ.getName());
		System.out.println("Salary  " +employ.getBasic());
	}
}
