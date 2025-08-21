
const Greeting = () => {
    const morning = () =>{
        return "Good Morning to All...";
    }
    const afternoon = () => {
        return "Good Afternoon to All...";
    }

    const evening = () => {
        return "Good Evening to All...";
    }
    return(
        <div>
            {morning()} <br/>
         
        </div>
    )
}

export default Greeting;