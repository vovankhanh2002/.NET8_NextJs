import { Student } from "@/type/Student";
import axios from "axios";

const apiClient = axios.create({
  baseURL: process.env.NEXT_PUBLIC_API_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

export const getStudents = async (): Promise<Student[]> => {
  const response = await apiClient.get("/student/all");
  return response.data;
};

export const createStudent = async (data: Omit<Student, "id">): Promise<Student> => {
  const response = await apiClient.post("/student", data);
  return response.data;
};

export const updateStudent = async (id: number, data: Partial<Student>): Promise<Student> => {
  const response = await apiClient.put(`/student/${id}`, data);
  return response.data;
};

export const deleteStudent = async (id: number): Promise<void> => {
  await apiClient.delete(`/student/${id}`);
};

export default apiClient;
