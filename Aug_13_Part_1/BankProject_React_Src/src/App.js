import logo from './logo.svg';
import './App.css';
import CreateAccount from './components/createAccount/createAccount';
import SearchAccount from './components/searchAccount/searchAccount';
import ShowAccount from './components/showAccount/showAccount';
import Deposit from './components/deposit/deposit';
import Withdraw from './components/withdraw/withdraw';

function App() {
  return (
    <div className="App">
     <CreateAccount /> <br/>
     <SearchAccount /> <br/>
     <ShowAccount /> <br/>
     <Deposit /> <br/>
     <Withdraw />
    </div>
  );
}

export default App;
