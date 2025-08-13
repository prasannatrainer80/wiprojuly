import axios from 'axios';
import React, {Component, useState} from 'react';

const EmployAdd = () => {
   const [data, setData] = useState({
        empno : 0, 
        name : '',
        gender : '',
        dept : '',
        desig : '',
        basic : 0
    })

    const addEmploy = () => {
      axios.post("https://localhost:7271/api/EmploysNew",{
        empno : data.empno,
        name : data.name,
        gender : data.gender,
        dept : data.dept,
        desig : data.desig,
        basic : data.basic
      }).then(resp => {
          alert(resp.data);
          console.log(resp.data);
        })

    }

    const handleChange = event => {
        setData({
            ...data,[event.target.name] : event.target.value  
        })
    }

     return (
    <div>
      
            <label>Employ Number : </label>
            <input type="number" name="empno" 
                value={data.empno} onChange={handleChange} /> <br/><br/>
            <label>Employ Name : </label>
            <input type="text" name="name" 
                value={data.name} onChange={handleChange} /> <br/><br/> 
            <label>Employ Gender : </label>
            <input type="text" name="gender" 
                value={data.gender} onChange={handleChange} /> <br/><br/> 

            <label>Employ Department : </label>
            <input type="text" name="dept" 
                value={data.dept} onChange={handleChange} /> <br/><br/> 
            <label>Employ Designation : </label>
            <input type="text" name="desig" 
                value={data.desig} onChange={handleChange} /> <br/><br/> 
            <label>Basic </label>
            <input type="number" name="basic" 
                value={data.basic} onChange={handleChange} /> <br/><br/> 
            <input type="button" value="Add Employ" onClick={addEmploy} /> 

    </div>
  )


}

export default EmployAdd;