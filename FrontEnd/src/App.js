import React, { Component } from "react";
import "./App.css";
import DogGroup from "./DogGroup";
import DogBreed from "./DogBreed";
import DogGroupDetails from "./DogGroupDetails";

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
      dogBreedImg: [""],
      allDogs: []
    };
  }
  componentDidMount() {
    fetch("https://localhost:44349/api/DogBreed")
      .then(res => res.json())
      .then(json => this.setState({ allDogs: json }));
  }
  5;
  addNewBreed = () => {
    const breed = {
      dogBreedImg: this.state.dogGroupImg
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
            <DogGroup dogGroupImg={this.state.dogGroupImg} />
          </div>
          <div className="DogGroupDetails">
            <DogGroupDetails dogGroupDetails={this.state.dogGroupDetails} />
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
