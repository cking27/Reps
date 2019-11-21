import React from "react";
import DatePicker from "react-datepicker";

import "react-datepicker/dist/react-datepicker.css";
// CSS Modules, react-datepicker-cssmodules.css
// import 'react-datepicker/dist/react-datepicker-cssmodules.css';

class RepsDatePicker extends React.Component {
  state = {
    startDate: new Date(),
    startText: this.getText()
  };

  getText(){
    return "Boo";
  }
  
  handleChange = date => {
    this.setState({
      startDate: date
    });

    this.updateDb(date);
  };

  updateDb(){
    var b = this.state.startDate.toLocaleDateString();
    alert("new date :" + b );

    fetch('https://localhost:5001/api/workout/createworkoutday', {
    method: 'post',
    body: JSON.stringify(this.state)
  }).then(function(response) {
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
        <button onClick={this.updateDb.bind(this)}>
          Start Workout
      </button>
      </div>
    );
  }
}

export default RepsDatePicker;
