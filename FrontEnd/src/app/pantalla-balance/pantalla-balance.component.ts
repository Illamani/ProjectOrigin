import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Usuario } from '../Usuario';
import { SharedDataServiceService } from '../shared-data-service.service';
import { balance } from '../Balance';
@Component({
  selector: 'app-pantalla-balance',
  templateUrl: './pantalla-balance.component.html',
  styleUrls: ['./pantalla-balance.component.css']
})
export class PantallaBalanceComponent implements OnInit {

  constructor(private http : HttpClient, private sharedDataService: SharedDataServiceService,  private router: Router) { }

  clave : string = 'balanceKey';
  myValue: string = "";
  PIN : number = 0;
  valor : Usuario | null = this.sharedDataService.valorRespuesta
  ValorNumeroTarjeta : number | undefined = this.valor?.numeroTarjeta
  BalanceInterface : balance | null = null;
  balance : number = 0;
  fechaVencimientoTarjeta : Date | null = null;

  ngOnInit(): void {
    const storedValorRespuesta = localStorage.getItem(this.clave);
    if(storedValorRespuesta){
      this.valor = JSON.parse(storedValorRespuesta)      
      this.ValorNumeroTarjeta = this.valor?.numeroTarjeta
    }
    console.log(this.balance);
    this.GetAccessByUsuarioAsync();
  }

  public GetAccessByUsuarioAsync(){
    console.log(this.ValorNumeroTarjeta)
    this.http.get(`https://localhost:44363/GetBalanceAsync?inputNumeroCuenta=${this.ValorNumeroTarjeta}`)
    .pipe(map(response => {
      console.log(`El valor que retorna es ` , response)
      const variable = response as balance
      this.sharedDataService.sharedBalance = variable
      this.BalanceInterface = variable
      this.balance = this.BalanceInterface.balanceTotal
      this.fechaVencimientoTarjeta = this.BalanceInterface.fechaVencimiento
      localStorage.setItem('balanceKey', JSON.stringify(variable))
      return variable;
    }))
    .subscribe(respuesta => {
      console.log(respuesta)
    })
  }
  public VolverAtras(){
    this.router.navigateByUrl('/pantallaOperacion')
  }
}
