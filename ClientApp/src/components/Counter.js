import React, { Component } from 'react';

export class Counter extends Component {
    static displayName = Counter.name;

    constructor(props) {
        super(props);
        this.state = { value: '' };
        this.result = { result: '' };
    }

    handleChange = (event) => {
        this.setState({ value: event.target.value });
    }

    handleSubmit(event) {
        var value = this.state.value
        event.preventDefault()
        fetch("calculator", {
            method: "POST",
            body: JSON.stringify({
                value
            })
        })
        this.state.result = fetch("calculator", {
            method: "GET"
        })
    }

    render() {
        return (
            <div>
                <h1>Calculator</h1>

                <p>Make an input of two numbers and an operator (+,-,/,*) between them <br></br>
                    or one number and "sin", "cos" or "tan" after a space <br></br>
                    and press "Calculate" button to get a result.</p>

                <input type="text" value={this.state.value} onChange={this.handleChange} onSubmit={this.handleSubmit} />

                <p aria-live="polite">Your result: <strong>{this.state.result}</strong></p>

                <button className="btn btn-primary" onClick={this.handleSubmit}>Calculate</button>
            </div>
        );
    }

}

