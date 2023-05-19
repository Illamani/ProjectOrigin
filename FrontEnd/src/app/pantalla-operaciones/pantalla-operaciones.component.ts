import { Component, OnInit } from '@angular/core';
import { Usuario } from '../Usuario';
import { SharedDataServiceService } from '../shared-data-service.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-pantalla-operaciones',
  templateUrl: './pantalla-operaciones.component.html',
  styleUrls: ['./pantalla-operaciones.component.css']
})
export class PantallaOperacionesComponent implements OnInit {

  constructor(private sharedDataService: SharedDataServiceService,private router: Router) { }

  clave : string = 'myFinalKey';
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
  public RedirectBalance(){
    this.router.navigateByUrl('/pantallaBalance')
  }
  public RedirectRetiro(){
    this.router.navigateByUrl('/pantallaRetiro')
  }

}
