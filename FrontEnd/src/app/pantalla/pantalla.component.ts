import { Component, OnInit } from '@angular/core';
import { SharedDataServiceService } from '../shared-data-service.service';
import { Injectable } from '@angular/core';
import { Usuario } from '../Usuario';
import { HttpClient } from '@angular/common/http'

@Component({
  selector: 'app-pantalla',
  templateUrl: './pantalla.component.html',
  styleUrls: ['./pantalla.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class PantallaComponent implements OnInit {
  constructor(private sharedDataService: SharedDataServiceService, private http : HttpClient) { 
    
    // const storedValorRespuesta = localStorage.getItem(this.clave);
    // console.log(storedValorRespuesta)
    // if(storedValorRespuesta){
    //   this.valor = JSON.parse(storedValorRespuesta)
    //   this.intValor = this.valor?.numeroTarjeta
    // }
  }
  clave : string = 'myFinalKey';
  myValue: string = "";
  PIN : number = 0;
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  ValorNumeroTarjeta : number | undefined = this.valor?.numeroTarjeta

  ngOnInit(): void {
    // localStorage.setItem(this.clave, JSON.stringify(this.valor))
    // console.log(`Llave: ${this.clave}, Valor: ${value}`);
    const storedValorRespuesta = localStorage.getItem(this.clave);
    if(storedValorRespuesta){
      this.valor = JSON.parse(storedValorRespuesta)
      console.log(`Este valor viene del storage ${this.valor}`);
      this.ValorNumeroTarjeta = this.valor?.numeroTarjeta
      console.log(this.ValorNumeroTarjeta);
    }
  }
  public GetAccessByUsuarioAsync(){
    this.http.get(`https://localhost:44363/api/Usuario/GetAccessByUsuarioAsync?numeroTarjeta=${this.ValorNumeroTarjeta}&PIN=${this.PIN}`)
    .subscribe(respuesta => console.log(respuesta))
  }
}
