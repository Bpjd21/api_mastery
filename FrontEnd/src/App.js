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
      dogGroupDetails: ["./images/Instructions.png"],
      dogBreedName: ["Husky",
      "German Shepard"],
      };
  }
  componentDidMount() {
    fetch("https://localhost:44384/api/DogBreeds")
      .then(res => res.json())
      .then(json => this.setState({ dogBreedName: json }));
  }

  addNewBreed = () => {
    const breed = {
      dogBreedImg: this.state.dogBreedName
    };
  
    fetch("https://localhost:44384/api/DogBreeds", {
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
  }
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
             groupList={this.groupList}       
            />
          </div>
                  
          <div className="DogBreed">
            <DogBreed 
            dogGroupDetails={this.dogGroupDetails}
            dogBreedImg={this.state.dogBreedName}
             />
          </div>
        </div>
      </div>
    );
  }
}

export default App;
