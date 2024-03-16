// DashboardMain.tsx
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
