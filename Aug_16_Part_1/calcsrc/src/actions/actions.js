export const sum = () => ({type:'SUM'}) 
export const sub = () => ({type:'SUB'})
export const mult = () => ({type:'MULT'}) 
// export const changeFirstNo = () => ({type:'CHANGE_FIRST_NUMBER'});

export const changeFirstNo = (value) => {
  return { type: "CHANGE_FIRST_NUMBER", payload: value };
};

export const changeSecondNo = (value) => {
    return {type:'CHANGE_SECOND_NUMBER', payload : value}
}