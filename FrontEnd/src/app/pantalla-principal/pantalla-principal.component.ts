import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { RestService } from '../rest.service';
@Component({
  selector: 'app-pantalla-principal',
  templateUrl: './pantalla-principal.component.html',
  styleUrls: ['./pantalla-principal.component.css']
})
export class PantallaPrincipalComponent implements OnInit {
  myValue: string;

  constructor(private http : HttpClient,private restService : RestService) { 
    this.myValue = '';
  } 
  ngOnInit(): void {
  }  
  sendData(value:string) {
    console.log('Valor ingresado:', value);
  }
  public cargarData(){
    this.restService.get(`https://localhost:44363/api/Usuario/GetUsuarioByUsuarioTarjetaAsync?input=${this.myValue}`)
    .subscribe(respuesta => console.log(respuesta))
  }
}
