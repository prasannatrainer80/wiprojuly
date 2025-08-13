import axios from 'axios';
import React, {Component, useState} from 'react';

const Withdraw = () => {
  const[result,SetResult] = useState('');
 const [data, setData] = useState({
          accountNo : 0,
          withdrawAmount : 0,
      })
  
     const handleChange = event => {
        setData({
            ...data,[event.target.name] : event.target.value  
        })
    }

    const withdrawAccount = () => {
     axios.post("https://localhost:7006/withdraw/"+data.accountNo + "/"+data.withdrawAmount).then(resp => {
        //   alert(resp.data);
        SetResult(resp.data);
          console.log(resp.data);
        })
    }

      return (
    <div>
            <label>Account No : </label>
            <input type="number" name="accountNo" 
                value={data.accountNo} onChange={handleChange} /> <br/><br/> 
            <label>Withdraw Amount : </label>
            <input type="number" name="withdrawAmount" 
                value={data.withdrawAmount} onChange={handleChange} /> <br/><br/> 
 
            <input type="button" value="Withdraw Account" onClick={withdrawAccount} /> 
            <br/><br/>
            <b>{result}</b>
    </div>
  )

}

export default Withdraw;