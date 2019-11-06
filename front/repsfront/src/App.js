import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Hero from "./components/Hero";
import RepsDatePicker from "./components/RepsDatePicker";
import Station from "./components/Station";

function App() {
  return (
    <div className="flex-container">
      <div className="title"> Reps! </div>

      <div className="break"></div>
      <RepsDatePicker className="RepsDatePicker" />
      <div className="break"></div>
      <div className="stations">
        <Station class />
        <Station class />
      </div>
      <div className="stations">
        <Station class />
        <Station class />
      </div>
      <div className="stations">
        <Station class />
        <Station class />
      </div>
      <div className="stations">
        <Station class />
        <Station class />
      </div>
    </div>
  );
}

export default App;
