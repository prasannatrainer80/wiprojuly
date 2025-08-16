import { useDispatch, useSelector } from "react-redux";
import { mahi,rajesh,narayana } from "./actions";

const Names = () => {
    // Access the sname value from the Redux store
    const sname = useSelector( (state) => state.sname)
    // Get the dispatch function from Redux
    const dispatch = useDispatch();
    return (
        <div>
            <h1>Student Name is : {sname}</h1>
            <input type="button" value="Mahi" onClick={() => dispatch(mahi())} />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Rajesh" onClick={() => dispatch(rajesh())} /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Narayana" onClick={() => dispatch(narayana())} />
        </div>
    )
}

export default Names;