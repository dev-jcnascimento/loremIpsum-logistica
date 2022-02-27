import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Clients } from '../models/clients';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  readonly url: string = 'https://localhost:7155/api';

  constructor(private http: HttpClient) { }

  getAllClients(): Observable<Clients[]> {
    return this.http.get<Clients[]>(`${this.url}/clients/v1`);
  }

  getByNameClients(firstname: string, lastname: string): Observable<Clients[]> {
    return this.http.get<Clients[]>(`${this.url}/clients/v1/getByName?firstName=${firstname}&lastName=${lastname}`);
  }

  postClients(client: Clients): Observable<Clients>{
    return this.http.post<Clients>(`${this.url}/clients/v1`,client);
  }

  deleteClients(cli: string): Observable<any> {
    return this.http.delete(`${this.url}/clients/v1/${cli}`);
  }
}
