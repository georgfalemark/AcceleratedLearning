console.log('Moi moi');

let root = document.getElementById("root");



class Input extends React.Component{

    state = { typed: '' };
    
    onChange = (event) => {
        this.setState({ typed: event.target.value });
    }

    render() {
        return (
            <div>
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
                <input type="text" onChange={this.onChange.bind(this)} value={this.state.typed} />
            </div>
        )
    }
}
ReactDOM.render(<div><Input /></div>, root);





