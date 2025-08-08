package com.java.cols;

public class SbExample1 {

	public static void main(String[] args) {
		StringBuilder sb = new StringBuilder("Welcome to Java Programming...Trainer Prasanna");
		System.out.println(sb);
		sb.insert(5, "Sonix");
		System.out.println(sb);
		sb.delete(5, 10);
		System.out.println(sb);
		sb.append("\nJava 5 trainer Prasanna...");
		System.out.println(sb);
	}
}
