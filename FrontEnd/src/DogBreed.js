import React, { Component } from "react";
import "./App.css";

class DogBreed extends Component {
  render() {
    const {
      dogBreedImg} = this.props;

    return <div>
      <div className="DogBreedList">
        <img src={dogBreedImg} />
      </div>

    </div>
  }
}

export default DogBreed;
