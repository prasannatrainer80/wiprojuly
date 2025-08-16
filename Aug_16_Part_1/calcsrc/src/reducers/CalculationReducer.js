const initialState = {
    firstNo : 0,
    secondNo : 0,
    result : 0
}

const CalculationReducer = (state = initialState, action) => {
    switch(action.type) {
         case "CHANGE_FIRST_NUMBER":
            return { ...state, firstNo: Number(action.payload) };
        case 'CHANGE_SECOND_NUMBER' :
            return {...state, secondNo : Number(action.payload)};
        case 'SUM' :
            return {...state, result : state.firstNo + state.secondNo} 
        case 'SUB' : 
            return {...state, result : state.firstNo - state.secondNo} 
        case 'MULT' : 
             return {...state, result : state.firstNo * state.secondNo} 
        default : {
            return state;
        }
    }
}
export default CalculationReducer;