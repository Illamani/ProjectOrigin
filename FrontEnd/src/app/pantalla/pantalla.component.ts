import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pantalla',
  templateUrl: './pantalla.component.html',
  styleUrls: ['./pantalla.component.css']
})
export class PantallaComponent implements OnInit {
  myValue: string;
  constructor() { 
    this.myValue = '';
  }

  ngOnInit(): void {
  }
  sendData(value: string) {
    console.log('Valor ingresado:', value);
  }
}
