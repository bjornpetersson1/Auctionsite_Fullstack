import { Route, Routes } from "react-router-dom";
import "./App.css";
import { AuctionsList } from "./views/auctions-list";
import { Navbar } from "./components/navigation-bar";
import { AuctionDetails } from "./views/auction-details";
import { Login } from "./views/login";
import { AuctionCreate } from "./views/auction-create";
import { Register } from "./views/register";
import { AdminPage } from "./views/admin";
import { Authprovider } from "./context/auth-context";

function App() {
  return (
    <>
      <Authprovider>
        <Navbar />
        <Routes>
          <Route path="/" element={<AuctionsList />} />
          <Route path="/auctions/:id" element={<AuctionDetails />} />
          <Route path="/login" element={<Login />} />
          <Route path="/register" element={<Register />} />
          <Route path="/create-auction" element={<AuctionCreate />} />
          <Route path="/admin" element={<AdminPage />} />
        </Routes>
      </Authprovider>
    </>
  );
}

export default App;
