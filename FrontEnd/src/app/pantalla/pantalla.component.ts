import { Component, OnInit } from '@angular/core';
import { SharedDataServiceService } from '../shared-data-service.service';
import { Injectable } from '@angular/core';
import { Usuario } from '../Usuario';

@Component({
  selector: 'app-pantalla',
  templateUrl: './pantalla.component.html',
  styleUrls: ['./pantalla.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class PantallaComponent implements OnInit {
  constructor(private sharedDataService: SharedDataServiceService) { 
    
    // const storedValorRespuesta = localStorage.getItem(this.clave);
    // console.log(storedValorRespuesta)
    // if(storedValorRespuesta){
    //   this.valor = JSON.parse(storedValorRespuesta)
    //   this.intValor = this.valor?.numeroTarjeta
    // }
  }
  clave : string = 'myFinalKey';
  myValue: string = "";
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  intValor : number | undefined = this.valor?.numeroTarjeta

  ngOnInit(): void {
    // localStorage.setItem(this.clave, JSON.stringify(this.valor))
    // console.log(`Llave: ${this.clave}, Valor: ${value}`);
    const storedValorRespuesta = localStorage.getItem(this.clave);
    if(storedValorRespuesta){
      this.valor = JSON.parse(storedValorRespuesta)
      console.log(`Este valor viene del storage ${this.valor}`);
      this.intValor = this.valor?.numeroTarjeta
      console.log(this.intValor);
    }
  }
  sendData(value: string) {
    // console.log('Valor ingresado:', value);
  }
}
