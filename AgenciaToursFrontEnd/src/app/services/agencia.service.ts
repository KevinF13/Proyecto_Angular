// import { Injectable } from '@angular/core';
// import {HttpClient} from '@angular/common/http'
// import { Agencia } from '../models/agencia';
// import { Observable } from 'rxjs';
// @Injectable({
//   providedIn: 'root'
// })
// export class AgenciaService {

//   constructor(private http:HttpClient) { }

//   url:string = "https://localhost:44395/api/Agencia";

//   getAgencia(){
//     return this.http.get(this.url);
//   }

//   addAgencia(agencia:Agencia):Observable<Agencia>{
//     return this.http.post<Agencia>(this.url, agencia);
//   }

//   updateAgencia(id:number, agencia:Agencia):Observable<Agencia>{
//     return this.http.put<Agencia>(this.url + `/${id}`, agencia);
//   }

//   deleteAgencia(id:number){
//     return this.http.delete<Agencia>(this.url + `/${id}`);
//   }
// }
