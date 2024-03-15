
import { NavLink } from "react-router-dom";
import logo from '../../assets/bovision-logo.svg'
import './Header.css'


function Header() {
    function handleLogin() {
        console.log("Klick")
    }


    return (
        <div className="HeaderDiv">
            <div className="HeaderLeft">
                <NavLink to="/"><img src={logo} alt="Logo" /></NavLink>
            </div>
            <div className="HeaderMid">
                <ul className="menuList">
                    <li> <NavLink to="/search">Sök Bostad</NavLink></li>
                    <li>Läsvärt</li>
                    <li>Annonsera</li>
                    <li>RegOnline</li>
                    <li>Kontakt</li>
                    <li>Om Bovision</li>
                </ul>

            </div>
            <div className="HeaderRight" onClick={ handleLogin }><button>Logga in</button></div>
        </div>
  )
}

export default Header