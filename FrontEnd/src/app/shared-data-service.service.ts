import { Injectable } from '@angular/core';
import { Usuario } from './Usuario';
import { balance } from './Balance';
import { Retiro } from './Retiro';
@Injectable({
  providedIn: 'root'
})
export class SharedDataServiceService {

  valorRespuesta : Usuario | null = null;
  sharedBalance : balance | null = null;
  sharedRetiro : Retiro | null = null;
  SharedNumeroTarjeta : number = 0;
  constructor() { 
  }
}
