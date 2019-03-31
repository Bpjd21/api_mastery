import React, { Component } from "react";
import './App.css';

class DogGroup extends Component {
  /*userSelectGroup = e => {
    const myUrl = new URL(e.target.src);
    this.props.groupList(myUrl.pathname);
  };*/
  render() {
    const { dogGroupImg }= this.props;
    const groupImg = dogGroupImg.map(item => (
      <li key={item}>
        <img src={item} alt="DogGroup" onClick={this.dogGroupImg} />
      </li>
    ));   

    return (
    <div>
      <ul id="groupImg">{groupImg}</ul>      
    </div> 
    )  
  }
}
export default DogGroup;
