import React, { Component } from "react";
import "./App.css";
import DogGroup from "./DogGroup";

class DogBreed extends Component {
  
  userAddNewBreed = event => {
    this.props.userAddName(event.target.value);
  };

  render() {
    const {
      dogBreedName,
      addNewBreed,
      deleteNewBreed,
      allDogs,
      currentDogGroupImg,
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
      <div className="UserSelectGroupImg">
      <img src={currentDogGroupImg}/>
    </div>     
      
      <ul className="userBreed">{userBreed}</ul>    
    <div>    
      <div className="Buttons">
        <label>            
          <br/>  
          <br/>     
          Dog Breed Name:
          <input type="text" value={dogBreedName} onChange={this.userAddNewBreed}/>
        </label>
        <button onClick={addNewBreed}>Add Dog</button>
      </div>     
    </div>
    </div>
    )
  }
}

export default DogBreed;
