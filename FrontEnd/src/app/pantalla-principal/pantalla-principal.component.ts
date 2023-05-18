import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'
@Component({
  selector: 'app-pantalla-principal',
  templateUrl: './pantalla-principal.component.html',
  styleUrls: ['./pantalla-principal.component.css']
})
export class PantallaPrincipalComponent implements OnInit {
  myValue: string;

  constructor(private http : HttpClient) { 
    this.myValue = '';
  } 
  ngOnInit(): void {
  }  
  sendData(value:string) {
    console.log('Valor ingresado:', value);
  }
}
