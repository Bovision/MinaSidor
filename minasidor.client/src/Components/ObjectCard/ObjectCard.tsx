
import "./ObjectCard.css";
import IProduct from "../../Interfaces/IProduct";

function ObjectCard({ object }: { object: IProduct}) {


  return (
    <div className="objectCard">
      <img src={object.mainImageUrl} />
      

      <div className="ObjectCardInfo">
        
        <h3>{object.address}</h3>
        <p className="area">{object.area}, {object.city}</p>
        <p className="type">{object.REAType}</p>
        
        <p className="price">{object.price}:-</p>
      </div>
    <div className="ObjectCardFooter">
      <p>{object.size} m2</p>
      <p>{object.rent} kr/mån</p>
      <p>{object.rooms} rum</p>

    </div>
    </div>
  );
}
export default ObjectCard;
