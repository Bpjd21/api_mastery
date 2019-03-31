import React, { Component } from "react";
import './App.css';

class DogGroup extends Component {
  render() {
    const {dogGroupImg } = this.props;
    const groupImg = dogGroupImg.map(item => (
      <li key={item}>
        <img src={item} alt="DogGroup" onClick={this.userSelectGroup} />
      </li>
    ));
  
   
    return <ul id="groupImg">{groupImg}</ul>;
  }
}

export default DogGroup;
