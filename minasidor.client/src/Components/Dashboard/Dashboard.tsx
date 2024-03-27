

import { useTranslation } from "react-i18next";



import './Dashboard.css';

const Dashboard = () => {
   // const { t } = useTranslation("dashboard");
    
    return (
        <div className="dashboard">
            <div>
                <h1>Detta är "Dashboard"</h1>
                <p className='rubrik'>{t('landingPage')}</p>
            </div>
        </div>
    );
};

export default Dashboard;
