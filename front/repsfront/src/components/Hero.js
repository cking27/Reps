import React from 'react';


const Hero = (props) => {
    const width = window.innerWidth;
    const height = window.innerHeight;
    
    const style = {
      'position': 'fixed',
      'top': 0, 
      'left': 0,
      'min-width': '100%',
      'min-height': '90%'
    }
    
    return(
      <div style={style}>
        <img src={`https://picsum.photos/id/870/200/300?grayscale&blur=`} style={style}/>
      </div>
    )
  }


  export default Hero;