import React, {Component, useContext} from 'react';
import { UserContext } from '../../context/UserContext';

const ContextEx2 = () => {
  
  const user = useContext(UserContext);
  return(
    <div>
      <p>User Name : <b>{user.userName}</b></p>
      <p>Company : <b>{user.company}</b></p>
      <p>Topic is : <b>{user.topic}</b></p>
    </div>
  )
}

export default ContextEx2;