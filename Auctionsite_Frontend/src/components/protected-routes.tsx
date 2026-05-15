import { Navigate, Outlet } from "react-router-dom";
import { useAuth } from "../context/auth-context";

export const ProtectedRoute = () => {
  const { user } = useAuth();
  return user.isAuthenticated ? <Outlet /> : <Navigate to="/login" replace />;
};

export const AdminRoute = () => {
  const { user } = useAuth();
  return user.role === "admin" ? <Outlet /> : <Navigate to="/" replace />;
};
