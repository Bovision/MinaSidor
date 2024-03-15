// DashboardMain.tsx
import React from 'react';
import { Route, Routes } from 'react-router';
import { useTranslation } from "react-i18next";



const DashboardMain = () => {
    const { t } = useTranslation("dashboard");


    return (
        <div className="dashboardMain">
            <p className='rubrik'>{t('startpage')}</p>
            
        </div>
    );
};

export default DashboardMain;
