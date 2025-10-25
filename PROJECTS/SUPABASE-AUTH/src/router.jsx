import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import SignUp from "./components/SignUp";
import Signin from "./components/Signin";
import Dashboard from "./components/Dashboard";

export const router = createBrowserRouter([
    {path: "/", element: <App/>},
    {path: "/signup", element: <SignUp/>},
    {path: "/signin", element: <Signin/>},
    {path: "/dashboard", element: <Dashboard/>}
]); 