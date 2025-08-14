import logo from './logo.svg';
import './App.css';
import ContextEx1 from './components/contextEx1/contextEx1';
import ContextEx2 from './components/contextEx2/contextEx2';
import ColorTheme from './components/colorTheme/colorTheme';
import FontTheme from './components/fontTheme/fontTheme';
import RefEx1 from './components/refEx1/refEx1';
import RefEx2 from './components/refEx2/refEx2';
import Memo1 from './components/memo1/memo1';
import Memo2 from './components/memo2/memo2';
import Memo3 from './components/memo3/memo3';

function App() {
  return (
    <div className="App">
     <ContextEx1 /> <br/>
     <ContextEx2 /> <br/>
     <ColorTheme /> <br/>
     <FontTheme /> <br/>
     <RefEx1 /> <br/>
     <RefEx2 /> <br/>
     <Memo1 /> <br/>
     <Memo2 /> <br/>
     <Memo3 />
    </div>
  );
}

export default App;
