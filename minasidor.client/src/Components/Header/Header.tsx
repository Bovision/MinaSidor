
import { NavLink } from "react-router-dom";
import logo from '../../assets/bovision-logo.svg'
import { useTranslation } from "react-i18next";
import './Header.css'


function Header() {
    const { t } = useTranslation("header");
    // function handleLogin() {
    //     console.log("Klick")
    // }


    return (
        <div className="HeaderDiv">
            <div className="HeaderLeft">
                <NavLink to="/"><img src={logo} alt="Logo" /></NavLink>
            </div>
            <div className="HeaderMid">
                <ul className="menuList">
                    <li> <NavLink to="/search">{t('search')}</NavLink></li>
                    <li>{t('tips')}</li>
                    <li>{t('advertise')}</li>
                    <li>{t('regonline')}</li>
                    <li>{t('contact')}</li>
                    <li>{t('about')}</li>
                </ul>

            </div>
            {/*<div className="HeaderRight" onClick={ handleLogin }><button>Logga in</button></div>*/}
            <div className="HeaderRight"><NavLink to="/dashboard"><button>Logga in</button></NavLink></div>
        </div>
  )
}

export default Header