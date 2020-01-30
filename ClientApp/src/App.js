import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { CalcLogs } from './components/CalcLogs';
import { Calculator } from './components/Calculator';
import { News } from './components/News';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
            <Route path='/calculator' component={Calculator} />
            <Route path='/calc-logs' component={CalcLogs} />
            <Route path='/news' component={News} />
      </Layout>
    );
  }
}
