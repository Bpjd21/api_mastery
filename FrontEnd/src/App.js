import React, { Component } from "react";
import "./App.css";
import DogGroup from "./DogGroup";
import DogBreed from "./DogBreed";

class App extends Component {
  constructor() {
    super();
    this.state = {
      dogGroupImg: [
        "./images/herding_group.jpg",
        "./images/Hounds_group.jpg",
        "./images/working-group.jpg"
      ],
      currentDogGroupImg:["./images/Instructions.png"],
      dogBreedName: [],
      allDogs: []

    };
      
      }
  componentDidMount() {
    fetch("https://localhost:44349/api/DogBreed")
      .then(res => res.json())
      .then(json => this.setState({ allDogs: json }));
  }

  userSelectGroup = imageUrl => {
    this.setState({ currentDogGroupImg: imageUrl})
  };

  addNewBreed = () => {
    const breed = {
      dogBreedName: this.state.dogBreedName
    };

    fetch("https://localhost:44349/api/DogBreed", {
      method: "POST",
      body: JSON.stringify(breed),
      headers: {
        "Content-Type": "application/json"
      }
    })
      .then(res => {
        if (res.ok) {
          const newDogs = [...this.state.allDogs, breed];
          this.setState({ allDogs: newDogs });
        }
      })
      .catch(err => {
        console.error(err);
      });
  };
  render() {
    return (
      <div className="App">
        <div className="Header">
          <img src="/images/group-of-dogs.jpg" />
          <p>Dog Groups and the Breeds Within</p>
        </div>
        <div className="Body">
          <div className="DogGroup">
            <DogGroup 
            dogGroupImg={this.state.dogGroupImg}
            userSelectGroup={this.userSelectGroup} 
            currentDogGroupImg={this.state.currentDogGroupImg}/>
          </div>         
          <div className="DogBreed">
            <DogBreed 
            currentDogGroupImg={this.state.currentDogGroupImg}
            dogBreedName={this.state.dogBreedName} 
            allDogs={this.state.allDogs}
            addNewBreed={this.addNewBreed}
            />
          </div>
        </div>
      </div>
    );
  }
}

export default App;
