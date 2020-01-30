import React, { Component } from 'react';

export class CalcLogs extends Component {
    static displayName = CalcLogs.name;

    constructor(props) {
        super(props);
        this.state = { calcLogs: [], loading: true };
    }

    componentDidMount() {
        this.populateCalcLogs();
    }

    static renderCalcLogs(calcLogs) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Query</th>
                        <th>Result</th>
                        <th>Time</th>
                    </tr>
                </thead>
                <tbody>
                    {calcLogs.map(calcLog =>
                        <tr key={calcLog.id}>
                            <td>{calcLog.id}</td>
                            <td>{calcLog.userQuery}</td>
                            <td>{calcLog.calculationResult}</td>
                            <td>{calcLog.operationTime}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : CalcLogs.renderCalcLogs(this.state.calcLogs);

        return (
            <div>
                <h1 id="tabelLabel" >Calculator Logs</h1>
                <p>Just because I can.</p>
                {contents}
            </div>
        );
    }

    async populateCalcLogs() {
        const response = await fetch('calclogs');
        const data = await response.json();
        this.setState({ calcLogs: data, loading: false });
    }
}
