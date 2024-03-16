// Dashboard.tsx
import {Route } from 'react-router-dom';
import { Routes } from 'react-router'
import DashboardHeader from './DashboardHeader/DashboardHeader';
import DashboardMenu from './DashboardMenu/DashboardMenu';
import DashboardMain from '../Dashboard/DashboardMain/DashboardMain';
import DashboardAnnonser from './DashboardAnnonser/DashboardAnnonser'
import DashboardIntresse from './DashboardIntresse/DashboardIntresse'
import DashboardLeads from './DashboardLeads/DashboardLeads'
import DashboardFakturering from './DashboardFakturering/DashboardFakturering'
import DashboardMarknad from './DashboardMarknad/DashboardMarknad';
//import { useTranslation } from "react-i18next";


import './Dashboard.css';

const Dashboard = () => {
   // const { t } = useTranslation("dashboard");
    
    return (
        <div className="dashboard">
            <aside className="dashboardMenu">
                <DashboardMenu />
            </aside>
            <div>
                <div className="dashboardHeader">
                    <DashboardHeader />
                </div>
                <div className="dashboardContent">
                    <Routes>
                        <Route path="/" element={<DashboardMain />} />
                        <Route path="/annonser" element={<DashboardAnnonser />} />
                        <Route path="/intresse" element={<DashboardIntresse />} />
                        <Route path="/leads" element={<DashboardLeads />} />
                        <Route path="/fakturering" element={<DashboardFakturering />} />
                        <Route path="/marknad" element={<DashboardMarknad />} />
                        
                    </Routes>
                </div>
            </div>
        </div>
    );
};

export default Dashboard;
