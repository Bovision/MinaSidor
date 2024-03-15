// import { useEffect, useState } from "react";

import { useTranslation } from "react-i18next";
import ObjectCard from "../../ObjectCard/ObjectCard";
import IProduct from "../../../Interfaces/IProduct";
import { useContext } from "react";
import { ObjectContext } from "../../../Context/ObjectContext";
import mockDB from '../../../mockDB/mockDB.json'



const DashboardAnnonser = () => {
    const { t } = useTranslation("dashboard");
    const { objects, setObjects } = useContext(ObjectContext);

    

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
        <div>
            <div className="REA-header">
                <p className='rubrik'>{t('reasestateads')}</p>
                <p className="REA-infotext">{t('realestateadsinfo')}</p>
                <button className="REAadvertiseAdsBtn">{t('REAadvertiseAdsBtn')}</button>
            </div>
            <div className="REA-cardListHeader">
                <h2 className="mellanrubrik">Bolagsnamn PH objekt (CPHst)</h2>
                <input type="text" className="REA-searchField" placeholder={t('REAadvertiseAdsSearch')} />
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




