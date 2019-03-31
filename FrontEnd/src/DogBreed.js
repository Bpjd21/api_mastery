import React, { Component } from "react";
import "./App.css";
import DogGroup from "./DogGroup";

class DogBreed extends Component {
  
  userAddNewBreed = e => {
    this.props.addNewBreed(this.props.dogBreedName);
  };

  render() {
    const {
      dogBreedName,
      addNewBreed,
      deleteNewBreed,
      allDogs,
      currentDogGroupImg
    } = this.props;
    const userBreed = allDogs.map(dog => (
      <div className="DogBreedList">
      <ul>
        <li key={dog}>
          <p>{dog.dogBreedName}</p>
        </li>
      </ul>        
    </div>
    ))
    return ( 
    
    <div>
      <ul className="FixedBreedList">{dogBreedName}</ul>
      <ul className="userBreed">{userBreed}</ul>
      <textarea>Add New Breed</textarea>
    
    <div>    
      <div className="Buttons">
      <button onClick={addNewBreed}>Add Breed</button>
      <button onClick={deleteNewBreed}>Delete Breed</button>
      </div>
    </div>
    </div>
    )
  }
}

export default DogBreed;
