import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { RestService } from '../rest.service';
import { map } from 'rxjs/operators';
import { Usuario } from '../Usuario';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pantalla-principal',
  templateUrl: './pantalla-principal.component.html',
  styleUrls: ['./pantalla-principal.component.css']
})
export class PantallaPrincipalComponent implements OnInit {
  myValue: string;

  constructor(
    private http : HttpClient,
    private restService : RestService,
    private router: Router) { 
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
  public convertirModelo(){
    this.http.get(`https://localhost:44363/api/Usuario/GetUsuarioByUsuarioTarjetaAsync?input=${this.myValue}`).pipe(map(response => {
        // Realiza la transformación del resultado en un objeto aquí
        return response as Usuario;
      })
    ).subscribe(data => {
      // El objeto transformado está disponible aquí
      console.log(data);
      if(data.ok == true){
        this.router.navigateByUrl('/pantalla');
      }
    });
  }
}
