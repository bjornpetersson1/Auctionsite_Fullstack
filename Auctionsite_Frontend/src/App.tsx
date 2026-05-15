import { Route, Routes } from "react-router-dom";
import "./App.css";
import { AuctionsList } from "./views/auctions-list";
import { Navbar } from "./components/navigation-bar";
import { AuctionDetails } from "./views/auction-details";
import { Login } from "./views/login";
import { AuctionCreate } from "./views/auction-create";
import { Register } from "./views/register";
import { AdminPage } from "./views/admin";
import { AuthProvider } from "./context/auth-context";
import { AdminRoute, ProtectedRoute } from "./components/protected-routes";

function App() {
  return (
    <>
      <AuthProvider>
        <Navbar />
        <Routes>
          <Route path="/" element={<AuctionsList />} />
          <Route path="/auctions/:id" element={<AuctionDetails />} />
          <Route path="/login" element={<Login />} />
          <Route path="/register" element={<Register />} />
          <Route element={<ProtectedRoute />}>
            <Route path="/create-auction" element={<AuctionCreate />} />
          </Route>
          <Route element={<AdminRoute />}>
            <Route path="/admin" element={<AdminPage />} />
          </Route>
        </Routes>
      </AuthProvider>
    </>
  );
}

export default App;
