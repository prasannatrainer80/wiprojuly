package com.java.ex;

class Data<T> {
	
	public void swap(T a, T b) {
		T t;
		t = a;
		a = b;
		b = t;
		System.out.println("A value  " +a+ " B value " +b);
	}
}

public class GenSwap {
	
	public static void main(String[] args) {
		Data data = new Data();
		int a=5, b=7;
		data.swap(a, b);
		String s1="Padma", s2="Vinod";
		data.swap(s1, s2);
		boolean b1 = true, b2 = false;
		data.swap(b1, b2);
		Employ e1 = new Employ(1, "Uday", "Java", "Programmer", 88423);
		Employ e2 = new Employ(3, "Pavan", "Dotnet", "Expert", 99244);
		data.swap(e1, e2);	
	}
}
