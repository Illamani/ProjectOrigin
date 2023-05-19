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
  PIN : number | null = null;
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  ValorNumeroTarjeta : number | undefined = this.valor?.numeroTarjeta

  ngOnInit(): void {
    const storedValorRespuesta = localStorage.getItem('myFinalKey');
    if(storedValorRespuesta){
      this.valor = JSON.parse(storedValorRespuesta)
      this.ValorNumeroTarjeta = this.valor?.numeroTarjeta
    }
  }
  public GetAccessByUsuarioAsync(){
    this.http.get(`https://localhost:44363/api/Usuario/GetAccessByUsuarioAsync?numeroTarjeta=${this.ValorNumeroTarjeta}&PIN=${this.PIN}`)
    .pipe(map(response => {
      const variable = response as Usuario
      this.sharedDataService.valorRespuesta = variable
      localStorage.setItem('myFinalKey', JSON.stringify(variable))
      return variable;
    }))
    .subscribe(respuesta => {
      if(respuesta.ok == true){
        this.router.navigateByUrl('/pantallaOperacion')
      }
      else{
        alert(`Operacion Fallida : ${respuesta.mensaje}`)
      }
    })
  }
}
