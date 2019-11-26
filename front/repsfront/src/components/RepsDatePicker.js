import React from "react";
import DatePicker from "react-datepicker";

import "react-datepicker/dist/react-datepicker.css";
// CSS Modules, react-datepicker-cssmodules.css
// import 'react-datepicker/dist/react-datepicker-cssmodules.css';

class RepsDatePicker extends React.Component {
  state = {
    startDate: new Date(),
    startText: "Create"
  };


  handleChange = date => {
    this.setState({
      startDate: date
    });

    this.updateDb(date);
  };

  handleTextChange = text => {
    this.setState({
      startText: text
    });

  };

  updateDb() {
    var b = this.state.startDate.toLocaleDateString();
    fetch('https://localhost:5001/api/workout/createworkoutday', {
      method: 'post',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ Date: this.state.startDate, Description: this.state.startText })
    }).then(function (response) {
      return response.json();
    });
  }

  render() {
    return (
      <div className="RepsDatePicker">
        <DatePicker
          selected={this.state.startDate}
          onChange={this.handleChange}
        />
       <input type="text" value={this.state.startText} onChange={(event) =>this.handleTextChange(event.target.value)} />

        <button onClick={this.updateDb.bind(this)}>
          Start Workout
      </button>
      </div>
    );
  }
}

export default RepsDatePicker;
