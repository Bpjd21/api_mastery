import React, { Component } from "react";
import DogBreed from "./DogBreed";
import './App.css';

class DogGroup extends Component {
  userSelectGroup = e => {
    const myUrl = new URL(e.target.src);
    this.props.groupList(myUrl.pathname);
  };
  render() {
    const {
      dogGroupImg,    
    }= this.props;

    const groupImg = dogGroupImg.map(group => (
      <li key={group}>
        <img src={group} alt="DogGroup" onClick={this.userSelectGroup} />
      </li>
    ));   

    return (
    <div><ul id="groupImg">{groupImg}</ul>  
    
    </div>   
    
    )
  }
}

export default DogGroup;
