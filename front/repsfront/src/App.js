import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Hero from "./components/Hero";
import RepsDatePicker from "./components/RepsDatePicker";
import Station from "./components/Station";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";


const testData  = [{"id":1,"name":"Bicep Curl","notes":null},{"id":2,"name":"Tricep ","notes":null}];




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
        {this.state.stations.map(profile => <Station {...profile}/>)}
    </div>
    );
  }

 

}


function App() {
  return (
    <Router>
      <div>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/admin">admin</Link>
            </li>
            
          </ul>
        </nav>

        {/* A <Switch> looks through its children <Route>s and
            renders the first one that matches the current URL. */}
        <Switch>
          <Route path="/admin">
            <Admin />
          </Route>
          <Route path="/session">
            <Session />
          </Route>
          <Route path="/">
            <Home />
          </Route>
        </Switch>
      </div>
    </Router>
  );
}


    


function Home() {
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

function Admin() {
  return <h2>Admin</h2>;
}

function Session() {
  return <h2>Session</h2>;
}



export default App;

