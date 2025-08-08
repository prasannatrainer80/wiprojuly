package com.java.gen;

class Demo<T> {
	public void swap(T a,T b) {
		T t;
		t = a;
		a = b;
		b = t;
		System.out.println("A value  " +a+ " B value  " +b);
	}
}

public class GenEx1 {
	public static void main(String[] args) {
		int a = 5, b = 7;
		Demo demo = new Demo();
		demo.swap(a, b);
		String s1="Surya", s2="Dinesh";
		demo.swap(s1, s2);
		double d1=12.5, d2=8.2;
		demo.swap(d1, d2);
		boolean b1 = true, b2 = false;
		demo.swap(b1, b2);
	}
}
