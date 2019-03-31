import React, { Component } from "react";
import "./App.css";
import DogGroup from "./DogGroup";

class DogBreed extends Component {
  
  userAddNewBreed = e => {
    this.props.addNewBreed(this.props.dogBreedName);
  };

  render() {
    const {
      dogGroupDetails,
      dogBreedName,
      addNewBreed,
      deleteNewBreed
    } = this.props;
    return <div>
      <div className="DogGroupDetails">
       <img src={dogGroupDetails} />
      </div>
      <div className="DogBreedList">
        <ul>
          <li>{dogBreedName}</li>
        </ul>        
      </div>
      <div className="Buttons">
      <button onClick={addNewBreed}>Add Breed</button>
      <button onClick={deleteNewBreed}>Delete Breed</button>
      </div>
    </div>
  }
}

export default DogBreed;
