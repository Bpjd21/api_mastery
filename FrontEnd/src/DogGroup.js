import React, { Component } from "react";
import './App.css';

class DogGroup extends Component {
  userDogGroupImg = e => {
    const myUrl = new URL(e.target.src);
    this.props.userSelectGroup(myUrl.pathname);
  };
 
  render() {

    const {
       dogGroupImg,
       userSelectGroup,
    }= this.props;
    const groupImg = dogGroupImg.map(item => (
      <li key={item}>
        <img src={item} alt="DogGroup" onClick={this.userDogGroupImg} />
      </li>
    ));   

    return (
    <div>
      <img src={userSelectGroup}/>
      <ul id="groupImg">{groupImg}</ul>      
    </div> 
    )  
  }
}
export default DogGroup;
