import axios from "axios";
import { iAppResponse } from "../appResponse";


export const login = async (email: string, password: string) => {
  const response = await axios.post<
  iAppResponse<{ accessToken: string; refreshToken: string }>
  >(`/user/login`, {
    email: email,
    password: password,
  }).catch((ex)=>{
    console.log(ex);
  });
  return response?.data;
};
export const refreshToken = async (data: {
  accessToken: string;
  refreshToken: string;
}) => {
  const response = await axios.post<
  iAppResponse<{ accessToken: string; refreshToken: string }>
  >(`/user/refreshToken`, data).catch((ex)=>{
    console.log(ex);
  });
  return response?.data;
};
export const register = async (email: string, password: string) => {
  const response = await axios.post<iAppResponse<{}>>(
    `/user/register`,
    {
      email: email,
      password: password,
    }
  ).catch((ex)=>{
    console.log(ex);
  });
  return response?.data;
};
export const logout = async () => {
  const response = await axios.post<iAppResponse<boolean>>(
    `/user/logout`
  ).catch((ex)=>{
    console.log(ex);
  });
  return response?.data;
};
export const profileApi = async () => {
  const response = await axios.post(`/user/profile`).catch((ex)=>{
    console.log(ex);
  });
  return response?.data;
};
