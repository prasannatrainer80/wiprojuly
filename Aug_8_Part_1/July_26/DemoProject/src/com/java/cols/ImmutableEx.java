package com.java.cols;

final class Java5 {
	final String topic;
	public Java5(String topic) {
		this.topic = topic;
	}
	
	public String getTopic() {
		return topic.toUpperCase();
	}
}
public class ImmutableEx {
	public static void main(String[] args) {
		Java5 obj = new Java5("Java FullStack");
		System.out.println(obj.getTopic());
		System.out.println(obj.topic);
	}
}
