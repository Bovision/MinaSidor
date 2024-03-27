// import Header from '../src/Components/Header/Header'
import DashboardHeader from './Components/Dashboard/DashboardHeader/DashboardHeader';
import Main from '../src/Components/Main/Main'
import DashboardMenu from './Components/Dashboard/DashboardMenu/DashboardMenu';
// import Footer from '../src/Components/Footer/Footer'
import ObjectContextProvider from './Context/ObjectContext';
import UserContextProvider from './Context/UserContext';
import ModalContextProvider from './Context/ModalContext';




function App() {
    
    return (
        <div>
            <ModalContextProvider>
                <UserContextProvider>
                    <ObjectContextProvider> 
                        {/* <Header /> */}
                        <aside className="dashboardMenu">
                            <DashboardMenu />
                        </aside>
                        <DashboardHeader />
                        <Main />
                        {/* <Footer /> */}
                    </ObjectContextProvider>
                </UserContextProvider>
            </ModalContextProvider>
        </div>
    );
    
}

export default App;