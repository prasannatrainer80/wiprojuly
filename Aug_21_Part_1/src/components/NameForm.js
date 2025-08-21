import { useState } from "react";

const NameForm = () => {
    const [sname,setName] = useState("")
    const [result,setResult] = useState("") 

    const show = () => {
        let res = "Entered Value is " +sname;
        setResult(res);
    }
    return(
        <div>
            <form>
                <p>Enter Your Name : 
                    <input type="text" name="sname" value={sname} 
                        onChange={ (e) => setName(e.target.value)} 
                        placeholder="Please Enter Your Name"
                    />
                </p> <br/> <br/>
                <input type="button" value="Show" onClick={show}  /> 
                <br/>
                {result}
            </form>
        </div>
    )
}

export default NameForm;