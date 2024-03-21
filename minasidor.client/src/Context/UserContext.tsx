import { useState, createContext, PropsWithChildren, useEffect } from "react";

import IUser from "../Interfaces/IUser";
// import mockDB from '../mockDB/mockDB.json'
import officeUsers from '../mockDB/officeUsers.json'
import { off } from "process";

interface UserContextProps {
    users: IUser[] | null;

    setUsers: React.Dispatch<React.SetStateAction<IUser[]>>
}

export const UserContext = createContext<UserContextProps>(null as any);

const UserContextProvider = ({ children }: PropsWithChildren) => {

  const [users, setUsers] = useState<IUser[]>([]);

  // if(officeUsers.length > 0) {
  //   setUsers(officeUsers)
  // }

useEffect(() => {
  setUsers(officeUsers)

}, [])

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
    <UserContext.Provider
      value={{
        // getObjects,
        // products,
        users, 
        setUsers

      }}
    >
      {children}
    </UserContext.Provider>
  );
};

export default UserContextProvider;
