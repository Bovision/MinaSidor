
// import React, { useContext } from 'react'
import './Modal.css'
// import { ModalContext } from '../../Context/ModalContext';
import ModalAdministerUsers from './ModalAdministerUsers/ModalAdministerUsers';



function Modal() {
//   const { showModal, setShowModal } = useContext(ModalContext);

//   function closeModal() {
//     setShowModal(!showModal)
//   }




  return (
    <div className='ModalBackdrop'>
        <div className='MainModal'>

        <ModalAdministerUsers />

        </div>

  
    
    
      

    </div>
  )
}

export default Modal