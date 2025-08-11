import React, {Component, useState} from 'react';

const Six = () => {

  const [sname,setName] = useState('')

   const handleChange = event => {
        setName(event.target.value)
        // alert(empno);
    }


  return(
    <div>
      <form>
        <label>Please Enter Your Name  </label>
        <input type="text" name='sname' value={sname} onChange={handleChange} />
        <br/>
        Student Name is : {sname}
      </form>
    </div>
  )
}

export default Six;