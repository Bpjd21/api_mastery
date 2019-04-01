import React, { Component } from "react";
import "./App.css";

class DogBreed extends Component {
  userAddNewBreed = event => {
    this.props.userAddName(event.target.value);
  };

  render() {
    const {
      dogBreedName,
      addNewBreed,
      allDogs,
      currentDogGroupImg
    } = this.props;
    const userBreed = allDogs.map(dog => (
      <li key={dog}>
        <p>{dog.dogBreedName}</p>
      </li>
    ));
    return (
      <div>
        <div className="UserSelectGroupImg">
          <img src={currentDogGroupImg} alt="CurrentDog" />
        </div>
        <ul className="userBreed">{userBreed}</ul>
        <div>
          <div className="Buttons">
            <label>
              <br />
              <br />
              Dog Breed Name:
              <input
                type="text"
                value={allDogs.dogBreedName}
                onChange={this.userAddNewBreed}
              />
            </label>
            <button onClick={addNewBreed}>Add Dog</button>
          </div>
        </div>
      </div>
    );
  }
}

export default DogBreed;
