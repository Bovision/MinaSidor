import Header from '../src/Components/Header/Header'
import Main from '../src/Components/Main/Main'
import Footer from '../src/Components/Footer/Footer'
import ObjectContextProvider from './Context/ObjectContext';




function App() {
    
    return (
        <div>
            <ObjectContextProvider>
                <Header />
                <Main />
                <Footer />
            </ObjectContextProvider>
        </div>
    );
    
}

export default App;