import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { SharedDataServiceService } from '../shared-data-service.service';
import { Retiro } from '../Retiro';
import { map } from 'rxjs/operators';
import { Usuario } from '../Usuario';
@Component({
  selector: 'app-pantalla-retiro',
  templateUrl: './pantalla-retiro.component.html',
  styleUrls: ['./pantalla-retiro.component.css']
})
export class PantallaRetiroComponent implements OnInit {

  valorRetirar : number | null = null;
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  ValorNumeroTarjeta : number | undefined = this.valor?.numeroTarjeta

  RetiroObjetoString : any | null =  null;
  retiroObjeto : Retiro | null = null;
  
  constructor(private router: Router,private http : HttpClient,private sharedDataService: SharedDataServiceService,) { }

  ngOnInit(): void {
    const storedValorRespuesta = localStorage.getItem('myFinalKey');
    if(storedValorRespuesta){
      this.valor = JSON.parse(storedValorRespuesta)
      this.ValorNumeroTarjeta = this.valor?.numeroTarjeta
    }
  }
  public VolverAtras(){
    this.router.navigateByUrl('/pantallaOperacion')
  }
  public retirarDinero(){ 
    this.http.get(`https://localhost:44363/GetRetiroAsync?retiro=${this.valorRetirar}&numeroTarjeta=${this.ValorNumeroTarjeta}`).pipe(map(response => {
        const variable = response as Retiro
        this.sharedDataService.sharedRetiro = variable
        this.RetiroObjetoString = JSON.stringify(variable)
        const data = JSON.parse(this.RetiroObjetoString);
        this.retiroObjeto = data as Retiro;
        return variable;
      })
    ).subscribe(data => {
      if(this.valorRetirar == 0){
        alert("Debe ingresar un valor")
      }
      if(this.retiroObjeto?.operacionExitosa == true){
        alert(`OperacionExitosa : ${this.retiroObjeto?.operacionDescripcion}`);
        this.router.navigateByUrl('/pantallaOperacion');
      }
      else{
        alert(`OperacionFallida : ${this.retiroObjeto?.operacionDescripcion}`);
      }
    });
  }
}
