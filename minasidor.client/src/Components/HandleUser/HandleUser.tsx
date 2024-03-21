import { useContext } from 'react'
import { useTranslation } from "react-i18next";
import { UserContext } from '../../Context/UserContext';
import IUser from '../../Interfaces/IUser';
import OfficeUsers from './OfficeUsers/OfficeUsers';
import './HandleUser.css'
import { stringify } from 'querystring';
import { ModalContext } from '../../Context/ModalContext';

function HandleUser() {
    const { t } = useTranslation("userPages");
    const { users } = useContext(UserContext);
    const { showModal, setShowModal } = useContext(ModalContext);

    

    let adminText;
    if(users!.length > 0) {

        switch(users![0].officeAdmin) { 
            case true: { 
                //statements; 
                adminText = "Ja"
                break; 
            } 
            case false: { 
                //statements; 
                adminText = "Nej"
                break; 
            } 
            default: { 
                //statements; 
                adminText = "Nej"
                break; 
            } 
        } 
    }
        
function handleOpenAdminModal(){
    setShowModal(!showModal)
    
}


  return (
    <div className='handleUser'>
        <div className='handleUserHeader'>
            <p className='rubrik'>{t('handleUsers')}</p>
            <p className='users-infotext'>{t('handleUsersInfo')}</p>
        </div>
        {/* "Konto och rättigheter"-segmentet */}
        <h2>{t('accountsAndRights')}</h2>
        <div className='currentUserRights'>

        {users && users.length > 0 ? 
            <>
                <div className='formUnit'>
                    <label htmlFor="">{t('officeAndId')}</label>
                    <input className="disabled" type="text" placeholder={users![0].office +  -  + users![0].bvID} />
                </div>

                <div className='formUnit'>
                    <label htmlFor="">{t('companyName')}</label>
                    <input className="disabled" type="text" placeholder={users[0].company} />
                </div>
            </>
            : 
                <p>Loading...</p>
            }

        </div>

        <hr/>

        <h2>{t('addUser')}</h2>
        {/* "Lägg till användre"-segmentet */}
        <div className='currentUserRights'>
            <div className='formUnit'>
                <label htmlFor=""> {t('role')} </label>
                <select>
                    <option value={"Val1"}>{t('superAdmin')}</option>
                    <option value={"Val2"}>{t('officeAdmin')}</option>
                    <option value={"Val3"}>{t('user')}</option>
                </select>
            </div>
            <div className='formUnit'>
                <label htmlFor="">{t('firstName')}</label>
                <input type="text" placeholder="Skriv in ett förnamn" />
            </div>
            <div className='formUnit'>
                <label htmlFor="">{t('lastName')}</label>
                <input type="text" placeholder="Skriv in ett efternamn" />
            </div>
            <div className='formUnit'>
                <label htmlFor="">{t('title')}</label>
                <input type="text" placeholder="Skriv in personens titel" />
            </div>
        </div>
        <div className='btnPositionDiv'>
            <button className='addUserBtn'>{t('addUserBtn')}</button>
        </div>
        <hr />
        <h2>Ändra rättighetsnivå på användare</h2>
        <p>Du som är kontorsadministratör kan ge andra användare högre rättigheter. Notera att du inte kan ändra rättigheter på andra kontorsadministratörer till användare.</p>
        
        {users && users.length > 0 ? 
            <>
                <div>
                    <p className='miniNamn'>{users![0].firstName} {users![0].lastName}</p>
                    <img className="officeUserImage" src={users![0].img} alt="Bild" />
                </div>
                <div className='userStyleInline'>
                    <div className='formUnit'>
                        <label htmlFor="">{t('firstName')}</label>
                        <input className='disabled' type="text" placeholder={users![0].firstName}/>
                    </div>
                    <div className='formUnit'>
                        <label htmlFor="">{t('lastName')}</label>
                        <input className='disabled' type="text" placeholder={users![0].lastName}/>
                    </div>
                    <div className='formUnit'>
                        <label htmlFor="">{t('officeAdmin')}</label>
                        <input className='disabled' type="text" placeholder={adminText}/>
                    </div>

                    <div className='formUnit'>
                        <label htmlFor="">{t('rights')}</label>


                            {/* Här loopar vi igenom användarens rättigheter */}
                        <div className='userRightsList'>
                            {users[0].rights!.map((rights: string) => (
                                <div key={rights} className='rightsNugget'>
                                <p>{t(rights)}</p>
                                </div>
                            ))}
                        </div>
                    </div>

                </div>
            </>
            : 
                <p>Loading...</p>
            }
        
        <div className='btnPositionDiv'>
            <button className='addUserBtn' onClick={handleOpenAdminModal}>{t('administerUser')}</button>
            </div>
        {/* Här slutar "Lägg till användre"-segmentet */}

                {/* Här har vi admin-panelen av sidan */}



                {/* Här slutar admin-panelen av sidan */}
    <hr />
        
        {/* Här listas företagets användare: */}
        <div className='officeUsers'>
            <div className='officeUsersHeader'>
                <h2>{t('officeUsers')}</h2>
                <input type="text" placeholder='Sök efter person'/>
            </div>

            {users!.map((user: IUser) => (
                <div className='officeUsersCard' key={user.email}>
                    <OfficeUsers user={user} />
                </div>
            ))}

        </div>
    </div>
  )
}

export default HandleUser