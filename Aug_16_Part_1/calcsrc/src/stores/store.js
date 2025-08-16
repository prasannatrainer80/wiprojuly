import { createStore } from "@reduxjs/toolkit";
import CalculationReducer from "../reducers/CalculationReducer";
const store = createStore(CalculationReducer);
export default store;