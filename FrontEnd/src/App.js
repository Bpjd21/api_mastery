import React, { Component } from "react";
import "./App.css";

class App extends Component {
  constructor() {
    super();
    this.state = {
      breedImage: [],
      breedDetails: "",
      allDogs: []
    };
  }
  componentDidMount() {
    fetch("https://localhost:44384/api/Dogs")
      .then(res => res.json())
      .then(json => this.setState({ allDogs: json }));
  }

  render() {
    return (
      <div className="App">
        <p>Test</p>
      </div>
    );
  }
}

export default App;
