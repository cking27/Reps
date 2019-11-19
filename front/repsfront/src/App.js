import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Hero from "./components/Hero";
import RepsDatePicker from "./components/RepsDatePicker";
import Station from "./components/Station";


const testData  = [{"id":1,"name":"Bicep Curl","notes":null},{"id":2,"name":"Tricep ","notes":null}];




class StationList extends React.Component {
  componentDidMount() {
    fetch('https://localhost:5001/api/workout/getstations')
    .then(res => res.json())
    .then((data) => {
      this.setState({ stations: data })
    })
    .catch(console.log)
  }

  render() {
  	return (
      <div className="stations">
        boo
    </div>
    );
  }

 

}


function App() {
  return (
    <div className="flex-container">
      <div className="title"> Reps! </div>

      <div className="break"></div>
      <RepsDatePicker className="RepsDatePicker" />
      <div className="break"></div>
      <StationList />
    </div>
  );
}

export default App;
