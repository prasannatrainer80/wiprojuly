import { useState } from "react";

const ButtonExample = () => {
    const [count,setCount] = useState(0);
    return(
        <div>
            <p>Clicked {count} times</p>
            <input type="button" value="Increment" onClick={() => setCount(count +1)} />
        </div>
    )
}

export default ButtonExample;