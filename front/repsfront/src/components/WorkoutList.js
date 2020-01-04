import React from 'react';
import Workout from "./Workout";


class WorkoutList extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      value: '',
      workoutdate: '',
      workoutdates: []
    };

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    this.setState({ value: event.target.value });
  }

  handleSubmit(event) {
    this.setState({ workoutdate: this.state.value });
    event.preventDefault();
  }

  componentDidMount() {
    let initialworkoutdates = [];
    fetch('https://localhost:5001/api/workout/getallworkoutdays')
      .then(response => {
        return response.json();
      }).then(data => {
        initialworkoutdates = data.map((planet) => {
          return planet
        });
        console.log(initialworkoutdates);
        this.setState({
          workoutdates: initialworkoutdates,
        });
      });
  }

  render() {

    let optionItems = this.state.workoutdates.map((aworkoutdate) =>
      <option key={aworkoutdate.date}>{aworkoutdate.date}</option>
    );
    return (


      <div>
        <form onSubmit={this.handleSubmit}>
          <label>
            Select Workout:
          <select value={this.state.value} onChange={this.handleChange}>
              {optionItems}
            </select>
          </label>
          <input type="submit" value="Submit" />
        </form>

        <Workout workoutdate={this.state.workoutdate} />
      </div>
    );
  }

}

export default WorkoutList;