import { createContext, useContext, useState } from "react";

type AuthContextType = {
  token: string | null;
  userId: number | null;
  userName: string | null;
  role: string | null;
  isAuthenticated: false;
};

const AuthContext = createContext<AuthContextType | null>(null);

export const Authprovider = ({ children }: { children: React.ReactNode }) => {
  return <></>;
};

// export const useAuth = () => {
//   const ctx = useContext(AuthContext);
//   if (!ctx) throw new Error("useAuth måste användas inom AuthProvider");
//   return ctx;
// };
