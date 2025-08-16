import { createStore } from "@reduxjs/toolkit";
import NameReducer  from "./NameReducer";
const Store = createStore(NameReducer);

export default Store;