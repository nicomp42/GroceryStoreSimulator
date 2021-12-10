import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs';
import { AppConfig } from '../config/AppConfig';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private httpClient: HttpClient, private appConfig: AppConfig) { }


  getStores(){
    return this.httpClient.get<Store[]>(this.appConfig.apiRootUrl + "/Stores")
  }
}

export interface Store{
  id: number
  name: string
  address: string
}
