// DashboardMenu.tsx
import './DashboardMenu.css'
import Ads from '../../../assets/Ads-1--Streamline-Ultimate 1.svg'
import Card from '../../../assets/Credit-Card-1--Streamline-Ultimate 1.svg'
import House from '../../../assets/House-Chimney-1--Streamline-Ultimate 1.svg'
import RealEstate from '../../../assets/Real-Estate-Building-House--Streamline-Ultimate 1.svg'
import RealEstateMessage from '../../../assets/Real-Estate-Message-House--Streamline-Ultimate 1.svg'
import RealEstatePerson from '../../../assets/Real-Estate-Person-Search-House-1--Streamline-Ultimate 1.svg'
import Logo from '../../../assets/bovision-logo.svg'
import { useTranslation } from "react-i18next";
import { Link } from 'react-router-dom';

const DashboardMenu = () => {
    const { t } = useTranslation("dashboard");
    return (
        <div className="dashboardMenuContent">
            <div><img src={Logo} className='menuLogo' /></div>
            <div className="dashboardMenuOptions">
                <div className='menuOption'><Link to="/"><img src={House} className='dashboardMenyIcon'></img>{t('startpage')}</Link></div>
                <div className='menuOption'><Link to="/annonser"><img src={RealEstate} className='dashboardMenyIcon'></img>{t('reasestateads')}</Link></div>
                <div className='menuOption'><Link to="/intresse"><img src={RealEstateMessage} className='dashboardMenyIcon'></img>{t('interests')}</Link></div>
                <div className='menuOption'><Link to="/leads"><img src={RealEstatePerson} className='dashboardMenyIcon'></img>{t('leads')}</Link></div>
                <div className='menuOption'><Link to="/fakturering"><img src={Card} className='dashboardMenyIcon'></img>{t('billing')}</Link></div>
                <div className='menuOption'><Link to="/marknad"><img src={Ads} className='dashboardMenyIcon'></img>{t('marketing')}</Link></div>
            </div>
            
        </div>
    );
};

export default DashboardMenu;
