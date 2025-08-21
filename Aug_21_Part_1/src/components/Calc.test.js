import Calc from "./Calc";
import { render, screen, fireEvent, waitFor } from '@testing-library/react';

describe("Calculation Utility Functions to be Tested", () => {
    test("Add Two Numbers to be Tested", () => {
        expect(Calc.sum(12,5)).toBe(17);
    })

    test("Sub Two Numbers to be Tested", () => {
        expect(Calc.sub(12,5)).toBe(7);
    })

    test("Mult Two Numbers to be Tested", () => {
        expect(Calc.mult(12,5)).toBe(60);
    })
});