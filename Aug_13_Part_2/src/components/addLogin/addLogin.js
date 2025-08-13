import React, {Component} from 'react';
import './addLogin.scss'
// import { connect } from "react-redux";
// import { bindActionCreators } from "redux";
// import * as addLoginActions from "../../store/addLogin/actions";
export default class addLogin extends Component {
    // constructor(props) {
    //     super(props);
    //     this.state = {};
    // }
    render() {
      return <div className="component-add-login">Hello! component addLogin</div>;
    }
  }
// export default connect(
//     ({ addLogin }) => ({ ...addLogin }),
//     dispatch => bindActionCreators({ ...addLoginActions }, dispatch)
//   )( addLogin );