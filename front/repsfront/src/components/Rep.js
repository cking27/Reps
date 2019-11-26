class Rep extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
          reps: [8, 7, 3],
        };
      }
  
    render() {
        const items = []

        for (const [index, value] of this.state.reps ) {
          items.push(<li key={index}>{value}</li>)
        }
      return (
        <div>
          <div>
            <div>Weight {this.props.weight}</div>
            {items}
          </div>
          
        </div>
        
      );
    }
  }
  
  
  
  export default Rep;
  