import React from "react";
import "../App.css";



class WorkoutStation extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            reps: [7, 9]
        };
    }

    createTable = () => {
        let table = []
        console.log('bo2o')
        // Outer loop to create parent
        for (let i = 0; i < this.state.reps.length; i++) {
            console.log('boo')
            //Create the parent and add the children
            table.push(<div>Count: {this.state.reps[i]}</div>)
        }
        return table
    }

    render() {

        return (
            <div>
                <div>
                    <div> {this.props.stationName} </div>
                    {this.createTable()}
            
          </div>

            </div>

        );
    }
}



export default WorkoutStation;
