import React from 'react'
import { useTranslation } from "react-i18next";
import './OfficeUsers.css'
import IUser from '../../../Interfaces/IUser';

function OfficeUsers({ user }: { user: IUser}) {
    const { t } = useTranslation("userPages");

  return (
    <>
        <div>
            <p className='miniNamn'>{user.firstName} {user.lastName}</p>
        <img className="officeUserImage" src={user.img} alt="Bild" />
        </div>
    <div className='officeUserCard'>
        <div className='formUnit'>
            <label htmlFor="">{t('firstName')}</label>
            <input className='disabled' type="text" placeholder={user.firstName}/>
        </div>
        <div className='formUnit'>
            <label htmlFor="">{t('lastName')}</label>
            <input className='disabled' type="text" placeholder={user.lastName}/>
        </div>
        <div className='formUnit'>
            <label htmlFor="">{t('title')}</label>
            <input className='disabled' type="text" placeholder={user.title}/>
        </div>
        <div className='formUnit'>
            <label htmlFor="">{t('email')}</label>
            <input className='disabled' type="text" placeholder={user.email}/>
        </div>
        <div className='formUnit'>
            <label htmlFor="">{t('phone')}</label>
            <input className='disabled' type="text" placeholder={user.tele}/>
        </div>
        <div className='formUnit'>
            <label htmlFor="">{t('officeAdmin')}</label>
            <input className='disabled' type="text" placeholder="Bool - Case? "/>
        </div>

        <div className='formUnit'>
            <label htmlFor="">{t('rights')}</label>
                {/* Här loopar vi igenom användarens rättigheter */}
            <div className='userRightsList'>
                {user.rights!.map((rights: string) => (
                    <div key={rights} className='rightsNugget'>
                    <p>{t(rights)}</p>
                    </div>
                ))}
            </div>
        </div>
        
        {/* 
        <div className='formUnit'>
            <label htmlFor="">{t('userStatus')}</label>

                
                <div className='activeUserSlider'>
                    <input type="checkbox" id="toggle" />
                    <label for="toggle" className="test"></label>
                    <p>Aktiv/Inaktiv</p>
                </div>

        </div>
         */}
         


        <hr/>
    </div>
    </>
  )
}

export default OfficeUsers

