

console.log("hello world! ");

let root = document.getElementById("root");


class Textruta extends React.Component {

    state = {
        color: { backgroundColor: "red" }
    }

    Validate = (event) => {

        let regex;

        if (this.props.ignoreracasing === "true") {
            regex = new RegExp(this.props.validera, "i");
        }
        else {
            regex = new RegExp(this.props.validera);
        }

        let regexMatch = regex.test(event.target.value);
        if (regexMatch) {
            this.setState({ color: { backgroundColor: "green" } });
        }
        else {
            this.setState({ color: { backgroundColor: "red" } });
        }
    }

    render() {
        return (
            <div className="textwrap">
                <label>{this.props.lejbel}</label>
                <input onChange={this.Validate.bind(this)} style={this.state.color} />
            </div>
        )
    }
}

class App extends React.Component {

    render() {
        return (
            <div>
                <Textruta lejbel="Förnamn" />
                <Textruta lejbel="Efternamn" validera="son$" />
                <Textruta lejbel="Email" validera="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b" ignoreracasing="true" />
            </div>
        )
    }
}

ReactDOM.render(<App />, root);
