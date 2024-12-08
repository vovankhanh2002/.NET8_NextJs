import { any } from "zod";
import { Attendance } from "./Attendance";
import { Result } from "./Result";

export interface Student {
    id: number;
    username: string;
    name: string;
    surname: string;
    email: string;
    phone: string;
    address: string;
    bloodType: string;
    sex: string;
    createdAt: string; // ISO date format
    birthday: string;  // ISO date format
    attendances: Attendance[];
    results: Result[];
  }