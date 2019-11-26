import React from "react";
import "./App.css";
import RepsDatePicker from "./components/RepsDatePicker";
import Station from "./components/Station";
import Workout from "./components/Workout";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link,
  NavLink,
  HashRouter
} from "react-router-dom";


const testData = [{ "id": 1, "name": "Bicep Curl", "notes": null }, { "id": 2, "name": "Tricep ", "notes": null }];

class StationList extends React.Component {
  state = {
    stations: [],
  };
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
        {this.state.stations.map(profile => <Station {...profile} />)}
      </div>
    );
  }
}



function App() {
  return (
    <HashRouter>
      <div >
        <div className="flex-container">
          <ul className="header">
            <li><NavLink exact to="/">Home</NavLink></li>
            <li><NavLink to="/workout">Workout</NavLink></li>
            <li><NavLink to="/admin">Admin</NavLink></li>
          </ul>
        </div>
        <div className="flex-container-content2">
          <Route exact path="/" component={Home} />
          <Route path="/workout" component={(props) => <Workout {...props} date="Nov 25" />} />
          <Route path="/admin" component={Admin} />
        </div>
      </div>
    </HashRouter>
  );
}

function Home() {
  return (
    <div className="flex-container">
      <div className="title"> Create a workout sesssion </div>
      <div className="break"></div>
      <RepsDatePicker className="RepsDatePicker" />

    </div>
  );
}

function Admin() {
  return (
    <div >
      <h2>Admin</h2>
      <StationList />
    </div>
  )
}

function Session() {
  return <h2>Session</h2>;
}



export default App;

