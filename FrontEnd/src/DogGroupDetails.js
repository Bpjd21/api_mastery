import React, { Component } from 'react';

class DogGroupDetails extends Component {
    render() {
        const { DogGroupDetails }= this.props;

        return (
         <div className="DogGroupDetails">
             <img src={DogGroupDetails} />
         </div>
        );
    }
}

export default DogGroupDetails;