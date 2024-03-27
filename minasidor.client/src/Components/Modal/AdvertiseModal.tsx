import React from 'react'
import './Modal.css'
import ModalAdministerUsers from './ModalAdministerUsers/ModalAdministerUsers';



function AdvertiseModal() {
  return (
<div className='ModalBackdrop'>
        <div className='MainModal'>

          <ModalAdministerUsers />

        </div>
    </div>
  )
}

export default AdvertiseModal
