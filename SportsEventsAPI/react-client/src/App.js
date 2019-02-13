import React, { Component } from 'react';
import { Route } from 'react-router';
import { FetchData } from './components/FetchData';
import './App.css';

class App extends Component {
  displayName = App.name

  render() {
    return (
      <div className="App">
        <header className="App-header">
            <FetchData/>
        </header>
      </div>
    );
  }
}

export default App;
