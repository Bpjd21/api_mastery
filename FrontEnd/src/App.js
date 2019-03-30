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
      dogBreedImg: ["./images/Instructions.png"],
      allDogs: []
    };
  }
  componentDidMount() {
    fetch("https://localhost:44384/api/DogBreeds")
      .then(res => res.json())
      .then(json => this.setState({ allDogs: json }));
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
            <DogGroup dogGroupImg={this.state.dogGroupImg} />
          </div>
          <div className="DogBreed">
            <DogBreed dogBreedImg={this.state.dogBreedImg} />
          </div>
        </div>
      </div>
    );
  }
}

export default App;
