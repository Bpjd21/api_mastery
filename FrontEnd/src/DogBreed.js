import React, { Component } from "react";
import "./App.css";

class DogBreed extends Component {
  
  userAddNewBreed = e => {
    this.props.addNewBreed(this.props.dogBreedImg);
  };

  render() {
    const {
      dogBreedImg,
      addNewBreed,
      deleteNewBreed
    } = this.props;
    return <div>
      <div className="DogBreedList">
        <img src={dogBreedImg} />
      </div>
      <div className="Buttons">
      <button onClick={addNewBreed}>Add Breed</button>
      <button onClick={deleteNewBreed}>Delete Breed</button>
      </div>
    </div>
  }
}

export default DogBreed;
