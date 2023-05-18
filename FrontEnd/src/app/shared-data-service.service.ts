import { Injectable } from '@angular/core';
import { Usuario } from './Usuario';
@Injectable({
  providedIn: 'root'
})
export class SharedDataServiceService {

  valorRespuesta : Usuario | null = null;
  constructor() { 
  }
}
