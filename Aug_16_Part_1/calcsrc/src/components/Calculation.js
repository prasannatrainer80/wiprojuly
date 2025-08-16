import { useDispatch, useSelector } from "react-redux";
import { sum,sub,mult, changeFirstNo, changeSecondNo } from "../actions/actions";

const Calculation = () => {
    const firstNo = useSelector( (state) => state.firstNo);
    const secondNo = useSelector( (state) => state.secondNo);
    const result = useSelector( (state) => state.result);
    const dispatch = useDispatch();

    return (
        <div>
            First Number : 
            <input type="number" name="firstNo" value={firstNo} 
                onChange={ (e) => dispatch(changeFirstNo(e.target.value))} /> <br/>
            Second Number : 
            <input type="number" name="secondNo" value={secondNo} 
                onChange={ (e) => dispatch(changeSecondNo(e.target.value))} /> <br/> 
            <input type="button" value="Sum" onClick={() => dispatch(sum())} /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Sub" onClick={() => dispatch(sub())} /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" value="Mult" onClick={() => dispatch(mult())} />
            <hr/>
            Result is : <b>{result}</b>
        </div>
    )
}

export default Calculation;