import React, { Component } from 'react';

export class News extends Component {
    static displayName = News.name;

    constructor(props) {
        super(props);
        this.state = { news: [], loading: true };
    }

    componentDidMount() {
        this.populateNewsData();
    }

    static renderNews(news) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>News</th>
                    </tr>
                </thead>
                <tbody>
                    {news.articles.map(article =>
                        <tr>
                            <td>
                                <div>
                                    <h1>{article.title} </h1>
                                    <br></br>
                                    <img src={article.urlToImage}></img>
                                    <br></br>
                                    <p>{article.description}</p>
                                    <br></br>
                                    <p> <a href={article.url}>Read more...</a></p>
                                </div>
                            </td>
                        </tr>
                    )}
                </tbody>
            </table>);
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : News.renderNews(this.state.news);

        return (
            <div>
                <h1>News</h1>
                {contents}
            </div>
        );
    }

    async populateNewsData() {
        const response = await fetch('https://newsapi.org/v2/top-headlines?country=us&apiKey=7b14f60aa1334a61912771ea556ae7e4');
        const data = await response.json();
        this.setState({ news: data, loading: false });
    }
}
