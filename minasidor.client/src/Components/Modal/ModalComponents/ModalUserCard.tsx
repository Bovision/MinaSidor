import React, { useContext } from 'react'

// import "./ObjectCard.css";
import IUser from '../../../Interfaces/IUser';
import { UserContext } from '../../../Context/UserContext';




function ModalUserCard({ user } : { user: IUser}) {
  
  const { users } = useContext(UserContext);

  let dropdownText;
    switch(user.rights[0]) { 
        case "officeAdmin": { 
            //statements; 
            dropdownText = "Kontorsadministratör"
            break; 
        } 
        case "user": { 
            //statements; 
            dropdownText = "Användare"
            break; 
        } 
        default: { 
            //statements; 
            dropdownText = "Kunde inte läsa"
            break; 
        } 
    } 
  
let loggedInAdmin = false;
if (users![0].rights[0] == "officeAdmin") {
  loggedInAdmin = true;
}



  return (
    <div className='ModalUser'>
      <div className='ModalUserCardLeft'>
        <img src={user.img} />
        <p>{user.firstName} {user.lastName}</p>
      </div>
      <div className='ModalUserCardRight'>
        <select >
            <option value="" disabled selected>{dropdownText}</option>
            {/* Nedan skall bara vara synlig om det är en SuperAdmin som är inloggad */}
            {/* <option value={"Val1"}>SuperAdmin</option> */}

            {loggedInAdmin ? 
              <option value={"Val2"}>Kontorsadmin</option>
              : 
              ""
            }
            <option value={"Val3"}>Användare</option>
        </select>
      </div>

    </div>
  )
}

export default ModalUserCard