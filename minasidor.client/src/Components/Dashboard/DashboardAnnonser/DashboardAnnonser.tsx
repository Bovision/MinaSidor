// import { useEffect, useState } from "react";

import { useTranslation } from "react-i18next";
import ObjectCard from "../../ObjectCard/ObjectCard";
import IProduct from "../../../Interfaces/IProduct";
import { useContext } from "react";
import { ObjectContext } from "../../../Context/ObjectContext";
import mockDB from '../../../mockDB/mockDB.json'
import Rocket from '../../../assets/Fireworks-Rocket--Streamline-Ultimate 1.svg'
import Searchicon from '../../../assets/majesticons_search-line.svg'


const DashboardAnnonser = () => {
    const { t } = useTranslation("dashboard");
    const { objects, setObjects } = useContext(ObjectContext);

    
    //NEDAN API anrop är ett exempel för hur man kan göra när backend väl färdigt. But ut url:en bara. 
    // useEffect(() => {
    //   const fetchObjects = async () => {
    //     const response = await fetch(`https://test.bovision.se/api/products/getproduct?productid=236019637`);
    //     const data = await response.json();
  
    //     setObjects(data);
        
    //   };
    //   fetchObjects();
    // }, []);

    
setObjects(mockDB)
    


    return (
        <div className="REA-page">
            <div className="REA-header">
                <p className='rubrik'>{t('reasestateads')}</p>
                <p className="REA-infotext">{t('realestateadsinfo')}</p>
                <button className="REAadvertiseAdsBtn"><img src={Rocket}/>{t('REAadvertiseAdsBtn')}</button>
            </div>
            <div className="REA-cardListHeader">
                <h2 className="mellanrubrik">Bolagsnamn PH objekt ({objects!.length}st)</h2>
                <div className="REA-searchCluster">
                    <img src={Searchicon} />
                    <input type="text" className="REA-searchField" placeholder= {t('REAadvertiseAdsSearch')} />
                </div>
            </div>
            <div className="REA-cardList">
            {objects!.map((object: IProduct) => (
        <div className="ProductCardRender" key={object.Id}>
          {/* <Link to={`/${product._id}`}> */}
            <ObjectCard object={object} />
          {/* </Link> */}
        </div>
      ))}
            </div>
        </div>
    );
};

export default DashboardAnnonser;




