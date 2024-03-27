import { useState, createContext, PropsWithChildren, useEffect } from "react";



interface ModalContextProps {
    // users: IModal[] | null;

    // setModals: React.Dispatch<React.SetStateAction<IModal[]>>
}

export const ModalContext = createContext<ModalContextProps>(null as any);

const ModalContextProvider = ({ children }: PropsWithChildren) => {

  // const [modal, setModal] = useState<IModal[]>([]);
const [showModal, setShowModal] = useState(Boolean)
const [showAdModal, setShowAdModal] = useState(Boolean)


useEffect(()=> {
  console.log("Nu ska vi toggla modalen");
  console.log(showModal);
}, [showModal])




  return (
    <ModalContext.Provider
      value={{
        // getObjects,
        // products,
        showModal, 
        setShowModal, 
        showAdModal, 
        setShowAdModal

      }}
    >
      {children}
    </ModalContext.Provider>
  );
};

export default ModalContextProvider;
