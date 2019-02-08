console.log("email03! ");

let root = document.getElementById("root");




class Textruta extends React.Component {
    render() {
        return (
            <div className="textwrap">
                <label>{this.props.lejbel}</label>
                <input />
            </div>
        )
    }
}

class App extends React.Component {
    render() {
        return (
            <div>
                <Textruta lejbel="Förnamn" />
                <Textruta lejbel="Efternamn" />
                <Textruta lejbel="Epost" />
            </div>
        )
    }
}
ReactDOM.render(<App />, root);

