import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { FetchEmployee } from './components/FetchEmployee';
import { AddEmployee } from './components/AddEmployee';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
            <Route path='/fetchemployee' component={FetchEmployee} />
            <Route path='/addemployee' component={AddEmployee} />
            <Route path='/employee/edit/:empid' component={AddEmployee} />
      </Layout>
    );
  }
}
