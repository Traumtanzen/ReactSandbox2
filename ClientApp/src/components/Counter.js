import React, { Component } from 'react';

export class Counter extends Component {
    static displayName = Counter.name;

    constructor(props) {
        super(props);
        this.state = { value: null, result: null };
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
    }

    showResult(event) {
        event.preventDefault()
        var result = fetch("calculator", {
            method: "GET"
        })
        this.setState({ result: event.target.value });
    }

    render() {
        return (
            <div>
                <h1>Calculator</h1>

                <p>Make an input of two numbers and an operator (+,-,/,*) between them <br></br>
                    or one number and "sin", "cos" or "tan" after a space <br></br>
                    and press "Calculate" button to get a result.</p>

                <input type="text" value={this.state.value} onChange={this.handleChange} />

                <p aria-live="polite">Your result: <strong>{this.showResult}</strong></p>

                <button className="btn btn-primary" onClick={this.handleSubmit}>Calculate</button>
            </div>
        );
    }

}

