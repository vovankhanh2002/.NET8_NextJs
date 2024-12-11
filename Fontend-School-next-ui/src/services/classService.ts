import { Class } from "@/type/Class";
import axios from "axios";

const apiClient = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

export const getClasss = async (): Promise<Class[]> => {
  const response = await apiClient.get("/Class/all");
  return response.data;
};

export const createClass = async (data: any): Promise<Class> => {
  const response = await apiClient.post("/Class", data);
  return response.data;
};

export const updateClass = async (id: number, data: Partial<Class>): Promise<Class> => {
  const response = await apiClient.put(`/Class/${id}`, data);
  return response.data;
};

export const deleteClass = async (id: number): Promise<void> => {
  await apiClient.delete(`/Class/${id}`);
};

export default apiClient;
