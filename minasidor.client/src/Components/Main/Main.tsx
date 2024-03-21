import { Route, Routes } from "react-router";

import React, { useContext } from 'react'

import './Main.css'
// import LandingPage from '../LandingPage/LandingPage'
import DashBoard from '../Dashboard/Dashboard'


import DashboardAnnonser from '../Dashboard/DashboardAnnonser/DashboardAnnonser'
import DashboardIntresse from '../Dashboard/DashboardIntresse/DashboardIntresse'
import DashboardLeads from '../Dashboard/DashboardLeads/DashboardLeads'
import DashboardFakturering from '../Dashboard/DashboardFakturering/DashboardFakturering'
import DashboardMarknad from '../Dashboard/DashboardMarknad/DashboardMarknad';
import HandleUser from "../HandleUser/HandleUser";
import Modal from "../Modal/Modal";
import { RegisterPage } from "../pages/RegisterPage";
import { LoginPage } from "../pages/LoginPage";
import { HomePage } from "../pages/HomePage";
import Search from '../Search/Search'

import { ModalContext } from "../../Context/ModalContext";


const  Main = () => {

    const { showModal } = useContext(ModalContext)


    return (
        <div className="MainDiv">

            
                <div className="routes">
                {showModal ? <Modal /> : ""} 
                    <Routes>
                        <Route path="/" element={<DashBoard /> } />
                        <Route path="/annonser" element={<DashboardAnnonser />} />
                        <Route path="/intresse" element={<DashboardIntresse />} />
                        <Route path="/leads" element={<DashboardLeads />} />
                        <Route path="/fakturering" element={<DashboardFakturering />} />
                        <Route path="/marknad" element={<DashboardMarknad />} />
                        <Route path="register" element={<RegisterPage />} />
                        <Route path="login" element={<LoginPage />} />
                         <Route index element={<HomePage />} />
                        <Route path="/handleuser" element={<HandleUser />} />
                        <Route path="/search" element={<Search />} />

                    </Routes>
                </div>
    </div>
  )
}

export default Main