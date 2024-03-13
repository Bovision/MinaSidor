import DashboardHeader from "../DashboardHeader/DashboardHeader"
import DashboardMenu from '../DashboardMenu/DashboardMenu'
import './Dashboard.css'



const Dashboard = () => {


    return (
        <div className="dashboard">
            <aside className="dashboardMenu">
                <DashboardMenu />
            </aside>
            <div>
                <div className="dashboardHeader">
                    <DashboardHeader />
                </div>

                <h1>Dashboard</h1>
                <p>Detta är förstasidan i kundportalen</p>
            </div>

        </div>
    );
};

export default Dashboard;