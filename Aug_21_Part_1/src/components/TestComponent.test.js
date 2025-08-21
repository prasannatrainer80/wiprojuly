import { render, screen } from "@testing-library/react";
import TestComponent from "./TestComponent";

describe("Test Component Contains Test Cases", () => {

    test("renders Hello, World! text", () => {
       render(<TestComponent />);
       const headingElement = screen.getByText(/Hello, World!/i);
       expect(headingElement).toBeInTheDocument();
    });

    test("renders Hi! text", () => {
       render(<TestComponent />);
       const headingElement = screen.getByText(/Hi/i);
        expect(headingElement).toBeInTheDocument();
    });

    test("renders an h2 element", () => {
        render(<TestComponent />);
        const headingElement = screen.getByRole("heading", { level: 2 });
        expect(headingElement).toHaveTextContent("Hi");
    });

      test("renders an h3 element", () => {
        render(<TestComponent />);
        const headingElement = screen.getByRole("heading", { level: 3 });
        expect(headingElement).toHaveTextContent("React Testing");
    });

      test("renders React Testing text", () => {
       render(<TestComponent />);
       const headingElement = screen.getByText(/React Testing/i);
        expect(headingElement).toBeInTheDocument();
    });
    test("renders an h1 element", () => {
    render(<TestComponent />);
    const headingElement = screen.getByRole("heading", { level: 1 });
    expect(headingElement).toHaveTextContent("Hello, World!");
  });
});