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

  updateDb(date){
    alert("new date :" + typeof date)
  }

  render() {
    return (
      <div className="RepsDatePicker">
        <DatePicker
          selected={this.state.startDate}
          onChange={this.handleChange}
        />
      </div>
    );
  }
}

export default RepsDatePicker;
