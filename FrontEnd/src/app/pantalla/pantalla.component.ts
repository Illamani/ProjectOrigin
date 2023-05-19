import { Component, OnInit } from '@angular/core';
import { SharedDataServiceService } from '../shared-data-service.service';
import { Injectable } from '@angular/core';
import { Usuario } from '../Usuario';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http'
import { map } from 'rxjs/operators';
@Component({
  selector: 'app-pantalla',
  templateUrl: './pantalla.component.html',
  styleUrls: ['./pantalla.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class PantallaComponent implements OnInit {
  constructor(private sharedDataService: SharedDataServiceService, private http : HttpClient, private router: Router) { 
  }
  clave : string = 'myFinalKey';
  myValue: string = "";
  PIN : number = 0;
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  ValorNumeroTarjeta : number | undefined = this.valor?.numeroTarjeta

  ngOnInit(): void {
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
    .pipe(map(response => {
      const variable = response as Usuario
      this.sharedDataService.valorRespuesta = variable
      localStorage.setItem('myFinalKey', JSON.stringify(variable))
      console.log(variable)
      return variable;
    }))
    .subscribe(respuesta => {
      console.log(respuesta)
      this.router.navigateByUrl('/pantallaOperacion')
    })
  }
}
