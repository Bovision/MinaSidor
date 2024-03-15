import { useState, createContext, PropsWithChildren } from "react";

import IProduct from "../Interfaces/IProduct";
// import mockDB from '../mockDB/mockDB.json'

interface ObjectContextProps {
    objects: IProduct[] | null;

    setObjects: React.Dispatch<React.SetStateAction<IProduct[]>>
}

export const ObjectContext = createContext<ObjectContextProps>(null as any);

const ObjectContextProvider = ({ children }: PropsWithChildren) => {

  const [objects, setObjects] = useState<IProduct[]>([]);

//   const getObjects = async () => {
//     const res = await fetch(`/api/products`);
//     const products = await res.json();
//     setObjects(products);    
//   };
//   useEffect(() => {
//     getObjects();
//   }, []);
  
// setObjects(mockDB)



  return (
    <ObjectContext.Provider
      value={{
        // getObjects,
        // products,
        objects, 
        setObjects

      }}
    >
      {children}
    </ObjectContext.Provider>
  );
};

export default ObjectContextProvider;
