
import React, { useContext } from 'react'
import './Modal.css'
import { ModalContext } from '../../Context/ModalContext';



function Modal() {
  const { showModal, setShowModal } = useContext(ModalContext);

  function closeModal() {
    setShowModal(!showModal)
  }




  return (
    <div className='MainModal'>
        Modal
        <button onClick={closeModal}>Stäng</button>
    </div>
  )
}

export default Modal