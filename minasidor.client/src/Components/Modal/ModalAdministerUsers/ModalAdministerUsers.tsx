import React, { useContext } from 'react'
import { UserContext } from '../../../Context/UserContext';
import IUser from '../../../Interfaces/IUser';
import ModalUserCard from '../ModalComponents/ModalUserCard';
import { ModalContext } from '../../../Context/ModalContext';
import Button from '../../UI/Button';

function ModalAdministerUsers() {
  const { users } = useContext(UserContext);

  const { showModal, setShowModal } = useContext(ModalContext);

  function closeModal() {
    setShowModal(!showModal)
  }





  return (
    <div>
        <div className='ModalHeader'>
          
          <div className='ModalAdministerUsersHeader'>
            <h1>Ändra rättigheter</h1>
            <p className='closeX' onClick={closeModal}>X</p>
          </div>

          <p className='modalInfo'>Du som är kontorsadministratör kan ge andra användare högre rättigheter. Notera att du inte kan ändra rättigheter på andra kontorsadministratörer till användare.</p>
        </div>

        <div className='modalSearchBar'>
          <h2>Kontorets Användare</h2>
          <input type="text" placeholder='Sök på namn eller e-postadress' />
        </div>
          <div className='modelUserListHeader'>
            <p>Namn</p>
            <p>Rättigheter</p>
          </div>

            {/* Här ska vi loopa igenom användarna ifrån det specifika kontoret */}
        <div className='modalUserList'>
          <div className='modalUserCard'>
            {users!.map((user: IUser) => (
              <div className='modalOfficeUsersCard' key={user.email}>
                <ModalUserCard user={user} />
              </div>
            ))}
          </div>
        </div>
            {/* Här slutar vi loopa igenom användarna ifrån det specifika kontoret */}


        <div className='modalBtnContainer'>
          <button className='btnSaveAdministerUsersModal'>Spara</button>
        </div>
      
    </div>
  )
}

export default ModalAdministerUsers