import './App.css';
import React from 'react';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      weather: {}
    };
  }
  componentDidMount() {
    document.title = "New York Weather";
    fetch(`http://${process.env.REACT_APP_HOST}/cities/ny`)
    .then(results => {
      return results.json();
    }).then(data => {
        this.setState({
          weather: data
        });
    });
  }
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1>{this.state.weather.cityName} Weather Today</h1>
          <h3>Atmosphere: {this.state.weather.atmoshphere}</h3>
          <h3>Low Temp: {this.state.weather.lowTemp}</h3>
          <h3>High Temp: {this.state.weather.highTemp}</h3>
          <h3>Wind Speed: {this.state.weather.windSpeed}</h3>
          <h3>Wind Direction: {this.state.weather.windDirection}</h3>
          <h3>Wind Direction: {this.state.weather.windDirection}</h3>
        </header>
      </div>
    );
  }
}

export default App;
