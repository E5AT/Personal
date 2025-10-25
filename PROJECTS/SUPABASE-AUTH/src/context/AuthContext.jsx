import { createContext, useEffect, useState, useContext } from "react";
import { supabase } from "../supabaseClient";

const AuthContext = createContext();

export const AuthContextProvider = ({ children }) => {
    const [session, setSession] = useState(undefined);

    //Sign up
    const signUpNewUser = async () =>{
        const{data, error} = await supabase.auth.signUp({
            email: email,
            password: password,
        });

        if(error){
            console.error("There was a problem signing up: ",error);
            return {success: false, error};
        }
        return{success: true, data};
    };
//https://youtu.be/1KBV8M0mpYI?si=xioZvyJUCY3BByxD&t=1144
    return(
        <AuthContext.Provider value={session}>
            {children}
        </AuthContext.Provider>
    )
}

export const UserAuth = () => {
    return useContext(AuthContext);
}