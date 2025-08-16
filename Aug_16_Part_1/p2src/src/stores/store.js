import { createStore } from "@reduxjs/toolkit";
import CouterReducer from "../reducers/CounterReducer";
const store = createStore(CouterReducer);
export default store;