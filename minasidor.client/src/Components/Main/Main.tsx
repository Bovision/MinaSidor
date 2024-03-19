import { Route, Routes } from "react-router";

import './Main.css'
import LandingPage from '../LandingPage/LandingPage'
import DashBoard from '../Dashboard/Dashboard'
import { RegisterPage } from "../pages/RegisterPage";
import { LoginPage } from "../pages/LoginPage";
import Search from '../Search/Search'
import { HomePage } from "../pages/HomePage";
const  Main = () => {
    return (
        <div className="MainDiv">
        
            <div className="routes">
                <Routes>
                    <Route path="/" element={<LandingPage />} />
                    <Route index element={<HomePage />} />
                    <Route path="/dashboard/*" element={<DashBoard />} />
                    <Route path="/search" element={<Search />} />
                    <Route path="register" element={<RegisterPage />} />
                    <Route path="login" element={<LoginPage />} />

                </Routes>
            </div>
        
    </div>
  )
}

export default Main