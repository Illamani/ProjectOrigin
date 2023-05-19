import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { PantallaComponent } from './pantalla/pantalla.component';
import { PantallaPrincipalComponent } from './pantalla-principal/pantalla-principal.component';

import { FormsModule } from '@angular/forms';
import { PantallaOperacionesComponent } from './pantalla-operaciones/pantalla-operaciones.component';
import { PantallaBalanceComponent } from './pantalla-balance/pantalla-balance.component';
import { PantallaRetiroComponent } from './pantalla-retiro/pantalla-retiro.component';

@NgModule({
  declarations: [
    AppComponent,
    PantallaComponent,
    PantallaPrincipalComponent,
    PantallaOperacionesComponent,
    PantallaBalanceComponent,
    PantallaRetiroComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
