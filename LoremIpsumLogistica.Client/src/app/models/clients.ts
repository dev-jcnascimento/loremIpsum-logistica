// import { Addresses } from "./addresses";

export interface Clients {
    id ?: string;
    fullName ?: string;
    firstName ?: string;
    lastName ?: string;
    birthDate: string;
    birthDateString ?: string;
    genre: string;
    // addresses: Addresses[];
}

export interface ClientEdit {
    id ?: string;
    firstName ?: string;
    lastName ?: string;
    birthDate: string;
    genre: string;
    // addresses: Addresses[];
}
