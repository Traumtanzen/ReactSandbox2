import React, { Component } from 'react';

export class Calculator extends Component {
    static displayName = Calculator.name;

    constructor(props) {
        super(props);
        this.state = { query: '', result: '' };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }


    handleChange = (event) => {
        this.setState({ query: event.target.value });
    }

    handleSubmit(event) {
        var that = this;
        var postedValue = this.state.query
        event.preventDefault()
        fetch("calculator", {
            headers: {
                "content-type": 'application/json'
            },
            method: "POST",
            body: JSON.stringify({ "query": postedValue })
        }).then(response => {
            if (response.status === 200) {
                return response.json();
            }

        }).then(function (data) {
            
            console.log(data); 
            that.setState({ result: data });
        });
        
    }


    render() {
        return (
            <div>
                <h1>Calculator</h1>

                <p>Make an input of two numbers and an operator (+,-,/,*) between them <br></br>
                    or one number and "sin", "cos" or "tan" after a space <br></br>
                    and press "Calculate" button to get a result.</p>

                <input type="text" value={this.state.query} onChange={this.handleChange} />

                <p aria-live="polite">Your result: <strong>{this.state.result}</strong></p>

                <button className="btn btn-primary" onClick={this.handleSubmit}>Calculate</button>
            </div>
        );
    }

}

