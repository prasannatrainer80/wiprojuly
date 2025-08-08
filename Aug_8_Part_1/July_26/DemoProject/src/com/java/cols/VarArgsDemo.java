package com.java.cols;

public class VarArgsDemo {

	public static void attendance(int dayNo, String...student) {
		System.out.print(dayNo + "   ");
		for (String s : student) {
			System.out.print(s + "  ");
		}
		System.out.println();
	}
	
	public static void main(String[] args) {
		attendance(1);
		attendance(2,"Nagaraju");
		attendance(3,"Nagaraju","Pavan");
		attendance(4,"Nagaraju","Pavan","Rajitha");
	}
}
