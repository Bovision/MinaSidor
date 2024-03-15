import './DashboardHeader.css'
import { useTranslation } from "react-i18next";
//Import ev EXEMPELBILD
import tessan from '../../../assets/profilbild_therese.jfif'


const DashboardHeader = () => {
    const { t } = useTranslation("dashboard");
    return (
        <div className="dashboardHeader">
            <div className="dashboardHeaderLeft">
                <p>{t('welcome')}, </p><p style={{ fontWeight: "600" }}>USERNAME PLACEHOLDER</p>
            </div>
            <div className="dashboardHeaderRight">
                <img src={tessan} className="dashboardHeaderProfilePic"></img>
                <p>Username</p>
            </div>

        </div>
    );
};

export default DashboardHeader;
