
import "./ObjectCard.css";
import IProduct from "../../Interfaces/IProduct";

function ObjectCard({ object }: { object: IProduct}) {


  return (
    <div className="objectCard">
      {/* <img src={object.image} /> */}
      <p>Bild</p>

      <div className="ObjectCardInfo">
        {/* <h3>{object.title}</h3> */}
        <h3>{object.address}</h3>
        <p>{object.price}:-</p>
        
        
      </div>
    </div>
  );
}
export default ObjectCard;
