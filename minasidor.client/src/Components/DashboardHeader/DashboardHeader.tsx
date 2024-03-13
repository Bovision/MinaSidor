import './DashboardHeader.css'
import tessan from '../../assets/profilbild_therese.jfif'

const DashboardHeader = () => {
    return (
        <div className="dashboardHeader">
            <div className="dashboardHeaderLeft">
                <p>Välkommen, </p><p style={{ fontWeight: "600" }}>USERNAME PLACEHOLDER</p>
            </div>
            <div className="dashboardHeaderRight">
                <img src={tessan} className="dashboardHeaderProfilePic"></img>
                <p>Username</p>
            </div>

        </div>
    );
};

export default DashboardHeader;
