
console.log("Hello from temp.js");

let root = document.getElementById("root");









//1)
//const Knapp = function () {
//    return (
//        <button>Gooo</button>
//        );
//}

////ICH HTML kod, kan inte blanda stora och små bokstäver
//ReactDOM.render(
//    <div>
//        <Knapp />
//        <Knapp />
//    </div>, root);












////2)
//const Button = function (props) {
//    return (
//        <div>
//            <h3>{props.minprop}</h3>
//            <button>{props.minprop}</button>
//        </div>
//    );
//}

//ReactDOM.render(<Button minprop="kör" />, root);












////3)
//class Button extends React.Component {

//    state = { number: 55 }

//    render() {
//        return (
//            <div>
//                <button>{this.state.number}</button>
//                <button>{this.state.number * 100}</button>
//            </div>
//        )
//    }
//}
//ReactDOM.render(<Button />, root);












//4)
//class Button extends React.Component {

//    handleClick = () => {
//        console.log("Klick i konsolen")
//    }

//    render() {
//        return (
//            <button onClick={this.handleClick}>Klicka!</button>
//        )
//    }
//}
//ReactDOM.render(<Button />, root);













////5)
//class Button extends React.Component {

//    state = { counter: 15, text: "POW" }

//    handleClick = () => {
//        this.setState({ ccounter: 100 });
//    }

//    render() {
//        return (
//            <button onClick={this.handleClick}>
//                Klicka {this.state.counter}
//                Text {this.state.text}
//            </button>
//        )
//    }
//}
//ReactDOM.render(<Button />, root);











////6)
//class Button extends React.Component {

//    state = { counter: 15 }

//    handleClick = () => {
//        this.setState((x) => {
//            return { counter: x.counter + 1 };
//        })
//    }

//    render() {
//        return (
//            <button onClick={this.handleClick}>
//                Öka med ett {this.state.counter}
//            </button>
//        )
//    }
//}
//ReactDOM.render(<Button />, root);











////7)
//class Button extends React.Component {

//    state = { counter: 15 }

//    handleClick = () => {
//        this.setState((x) => {
//            return { counter: x.counter + 2 };
//        })
//    }

//    render() {
//        return (
//            <button onClick={this.handleClick}>
//                Öka med två {this.state.counter}
//            </button>
//        )
//    }
//}
//ReactDOM.render(<div><Button /><Button /><Button /></div>, root);









////8)
//class Button extends React.Component {

//    state = { counter: 0, mouseOver: 0 }

//    handleClick = () => {
//        this.setState((x) => {
//            return { counter: x.counter + 1 };
//        })
//    }

//    handlemouseOver = () => {
//        this.setState((x) => {
//            return { mouseOver: x.mouseOver + 1 };
//        })
//    }

//    render() {
//        return (
//            <button onClick={this.handleClick} onMouseOver={this.handlemouseOver} >
//                Antal klick: {this.state.counter} Mus över: {this.state.mouseOver}
//            </button>
//        )
//    }
//}
//ReactDOM.render(<div><Button /><Button /><Button /></div>, root);


























