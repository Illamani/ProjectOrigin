import { Component } from '@angular/core';
import { RestService } from './rest.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FrontEnd';
  constructor(private restService : RestService) {    
  }
  ngOnInit(): void {
    this.cargarData()
    
  }
  public cargarData(){
    this.restService.get('https://localhost:44363/GetPrueba')
    .subscribe(respuesta => console.log(respuesta))
  }
  // public cargarSegundaData(){
  //   this.restService.get.
  // }
}
