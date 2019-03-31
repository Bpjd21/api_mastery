import React, { Component } from 'react';

class DogGroupDetails extends Component {
    render() {

        const {
            dogGroupDetails,
          }= this.props;

        return (
         <div className="DogGroupDetails">
             <img src={dogGroupDetails} />
         </div>
        );
    }
}

export default DogGroupDetails;