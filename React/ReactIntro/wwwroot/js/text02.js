console.log('Bonjour');

let root = document.getElementById("root");





class Input extends React.Component {

    state = { typed: '', reveredTyped: '' };

    onChange = (event) => {

        let nameInputField = event.target.name;

        let str = event.target.value;
        let reversed = str.split("").reverse().join("");


        if (nameInputField == "orvar") {
            this.setState({ typed: reversed, reveredTyped: str });
        }
        else {
            this.setState({ reveredTyped: reversed, typed: str });
        }


    }





    render() {
        return (
            <div>
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.reveredTyped} name="orvar" />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
            </div>
        )
    }
}
ReactDOM.render(<div><Input /></div>, root);


