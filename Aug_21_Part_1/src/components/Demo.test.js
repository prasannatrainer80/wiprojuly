import React from 'react';
import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import Demo from './Demo';

describe('Demo Component', () => {
    test("renders welcome message", () => {
        render(<Demo />)

        const messageElement = screen.getByText("Welcome to React Testing...") 
        expect(messageElement).toBeInTheDocument();
    })
})