import './DashboardHeader.css'
import { useTranslation } from "react-i18next";
//Import ev EXEMPELBILD
import tessan from '../../../assets/profilbild_therese.jfif'
import bell from '../../../assets/knapp_notiser.svg'
import { useContext } from 'react';
import { UserContext } from '../../../Context/UserContext';


const DashboardHeader = () => {
    const { t } = useTranslation("dashboard");
    const { users } = useContext(UserContext);

    
    return (
        
        <div className="dashboardHeader">
            
            <div className="dashboardHeaderLeft">
                <p>{t('welcome')}, </p><p style={{ fontWeight: "600" }}>USERNAME PLACEHOLDER</p>
            </div>
            <div className="dashboardHeaderRight">
                <img src={bell} alt="" />
                <img src={tessan} className="dashboardHeaderProfilePic"></img>
                {users && users.length > 0 ? 
                    <p>{users![0].firstName}</p>
                    :
                    ""                
                }
            </div>
            
        </div>
        
    );
};

export default DashboardHeader;
