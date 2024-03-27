import React from 'react'

// import "./ObjectCard.css";
import IUser from '../../../Interfaces/IUser';

function ModalUserCard({ user } : { user: IUser}) {
  return (
    <div className='ModalUser'>
      <div className='ModalUserCardLeft'>
        <img src={user.img} />
        <p>{user.firstName} {user.lastName}</p>
      </div>

      <div className='ModalUserCardRight'>
        <p>Rättigheter-dropdown</p>
      </div>

    </div>
  )
}

export default ModalUserCard