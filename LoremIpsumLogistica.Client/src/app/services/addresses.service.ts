import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Addresses } from '../models/addresses';

@Injectable({
  providedIn: 'root'
})
export class AddressesService {

  readonly url: string = 'https://localhost:7155/api';

  constructor(private http: HttpClient) { }

  getAddressesByClient(clientId: string): Observable<Addresses[]> {
    return this.http.get<Addresses[]>(`${this.url}/addresses/v1/getByClientId?clientId=${clientId}`);
  }

  // getByIdAddresses(id: string): Observable<Addresses> {
  //   return this.http.get<Addresses>(`${this.url}/addresses/v1/${id}`);
  // }

  postAddresses(address: Addresses): Observable<Addresses>{
    return this.http.post<Addresses>(`${this.url}/addresses/v1`,address);
  }

  putAddresses(address: Addresses): Observable<Addresses>{
    return this.http.put<Addresses>(`${this.url}/addresses/v1/`,address);
  }

  deleteAddresses(address: string): Observable<any> {
    return this.http.delete(`${this.url}/addresses/v1/${address}`);
  }

}
