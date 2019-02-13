import React, { Component } from 'react';

export class FetchData extends Component {
    displayName = FetchData.name

    constructor(props) {
        super(props);
        this.state = { events: [], loading: true };

        fetch('https://localhost:44343/api/values')
            .then(response => { console.log(response);response.json() })
            .then(data => {
                this.setState({ events: data, loading: false });
            });
    }



    static renderEventsTable(events) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Event Name</th>
                        <th>Result</th>
                        <th>Start Date</th>
                    </tr>
                </thead>
                <tbody>
                    {events.map(elt =>
                        <tr key={elt.id}>
                            <td>{elt.name}</td>
                            <td>{elt.result}</td>
                            <td>{elt.startDate}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderEventsTable(this.state.events);

        return (
            <div>
                <h1>Fitogram Backend Test</h1>
                <p>The backend task is to create a Web API using .net core to return a list of sports events of a provider..</p>
                {contents}
            </div>
        );
    }
}