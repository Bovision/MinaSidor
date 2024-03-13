import { Route, Routes } from "react-router";
import React from 'react'

import './Main.css'

import DashBoard from '../Dashboard/Dashboard'
import Search from '../Search/Search'

const  Main = () => {
    return (
        <div className="MainDiv">
        
            <div className="routes">
                <Routes>
                    <Route path="/" element={<DashBoard />} />
                    <Route path="/search" element={<Search />} />
                    {/*<Route path="/shopingcart" element={<ShopingCart />} />*/}
                    {/*<Route path="/kontakta-oss" element={<Contact />} />*/}
                    {/*<Route path="/kassa" element={<Checkout />} />*/}
                    {/*<Route path="/order" element={<OrderConfirm />} />*/}
                    {/*<Route path="/adminpanel" element={<Adminpanel />} />*/}
                    {/*<Route path="/news" element={<News />} />*/}
                    {/*<Route path="/rea" element={<Rea />} />*/}
                </Routes>
            </div>
        
    </div>
  )
}

export default Main