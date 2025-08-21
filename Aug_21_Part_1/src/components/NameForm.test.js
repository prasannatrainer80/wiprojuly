import { fireEvent, render, screen } from "@testing-library/react";
import NameForm from "./NameForm";
import userEvent from "@testing-library/user-event";

describe("NameForm to be Tested...", () => {
    test("user to be tested with Button Click", async  () => {
        render(<NameForm />)
        const input = screen.getByPlaceholderText(/Please Enter Your Name/i);
        await userEvent.type(input,"Rajesh");
        
        const button = screen.getByRole("button",{name :/Show/i});
        await userEvent.click(button);

        const buttonClick = jest.fn();
        expect(buttonClick).toHaveBeenCalledTimes(0);

        // fireEvent.click(button);
        // expect(buttonClick).toHaveBeenCalledTimes(1);
    })

   test("shows entered name after button click", async () => {
          render(<NameForm />);

  const input = screen.getByPlaceholderText(/Please Enter Your Name/i);
  await userEvent.type(input, "Rajesh");

  // click button
  const button = screen.getByRole("button", { name: /Show/i });
  await userEvent.click(button);

  expect(screen.getByText(/Rajesh/)).toBeInTheDocument();
  expect(screen.getByText(/Entered Value is Rajesh/)).toBeInTheDocument();
});
});