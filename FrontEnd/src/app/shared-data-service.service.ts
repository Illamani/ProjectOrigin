import { Injectable } from '@angular/core';
import { Usuario } from './Usuario';
import { balance } from './Balance';
@Injectable({
  providedIn: 'root'
})
export class SharedDataServiceService {

  valorRespuesta : Usuario | null = null;
  SharedNumeroTarjeta : number = 0;
  sharedBalance : balance | null = null;
  constructor() { 
  }
}
