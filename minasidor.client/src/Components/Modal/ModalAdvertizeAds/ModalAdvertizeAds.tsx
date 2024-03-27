import React, { useContext } from 'react'
import { ModalContext } from '../../../Context/ModalContext';

function ModalAdvertizeAds() {


    const { showAdModal, setShowAdModal } = useContext(ModalContext);

    function closeModal() {
      setShowAdModal(!showAdModal)
    }

    

  return (
    <div>
        <div className='ModalAdministerUsersHeader'>
            <h1>Ändra rättigheter</h1>
            <p className='closeX' onClick={closeModal}>X</p>
        </div>
  </div>
    
  )
}

export default ModalAdvertizeAds