import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Registro } from './registro/models/registro';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {
  constructor(private http:HttpClient) { }

  url:string = "https://localhost:44395/api/Usuario";

  getAgencia(){
    return this.http.get(this.url);
  }

  addUsuario(registro:Registro):Observable<Registro>{
    return this.http.post<Registro>(this.url, registro);
  }
}
