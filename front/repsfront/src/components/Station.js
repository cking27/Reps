import React from "react";
import "../App.css";


class Station extends React.Component {
	render() {
  	const profile = this.props;
  	return (
          <div className="station">{profile.name}</div>
    );
  }
}


export default Station;
