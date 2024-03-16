import { Route, Routes } from "react-router";

import './Main.css'
import LandingPage from '../LandingPage/LandingPage'
import DashBoard from '../Dashboard/Dashboard'
import Login from '../Auth/Login'

import Search from '../Search/Search'

const  Main = () => {
    return (
        <div className="MainDiv">
        
            <div className="routes">
                <Routes>
                    <Route path="/" element={<LandingPage /> } />
                    <Route path="/dashboard/*" element={<DashBoard />} />
                    <Route path="/Login" element={<Login />} />
                    <Route path="/search" element={<Search />} />

                </Routes>
            </div>
        
    </div>
  )
}

export default Main