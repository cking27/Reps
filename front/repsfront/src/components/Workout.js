import React from "react";
import "../App.css";
import WorkoutStation from "./WorkoutStation.js"

class Workout extends React.Component {
  constructor(props) {
    super(props);
  }


  render() {
    const profile = this.props;
    console.log('workout date is ' + this.props.workoutdate );
    if (this.props.workoutdate ) {
      return (
        <div>
          <div className="title"> Workout Day : {this.props.date} </div>
          <div className="flex-container-content">
            <div> <WorkoutStation stationName="Biceps" weight="90" /></div>
            <div> <WorkoutStation stationName="Triceps" weight="22" /></div>
          </div>
          <div></div>
  
  
        </div>
  
      );
    }
    else
    {
      return (
        <div> </div>
      )
    }
    
  }
}



export default Workout;



