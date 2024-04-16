import { Colaborador } from './../Models/Colaborador';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Response } from '../Models/Response';
import { FormGroup } from '@angular/forms';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})


export class ColaboradorService {

  private api = `${environment.api}/Colaborador`

  constructor(private http: HttpClient) { }

  GetColaboradores(): Observable<Response<Colaborador[]>>{
   return this.http.get<Response<Colaborador[]>>(this.api);
  }

  createColaborador(colaborador: Colaborador): Observable<Response<Colaborador[]>>{
  return this.http.post<Response<Colaborador[]>>(`${this.api}`, colaborador);
  
  }


}






