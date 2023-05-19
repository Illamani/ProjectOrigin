import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PantallaComponent } from './pantalla/pantalla.component';
import { PantallaPrincipalComponent } from './pantalla-principal/pantalla-principal.component';
import { PantallaOperacionesComponent } from './pantalla-operaciones/pantalla-operaciones.component';
import { PantallaBalanceComponent } from './pantalla-balance/pantalla-balance.component';
import { PantallaRetiroComponent } from './pantalla-retiro/pantalla-retiro.component';

const routes: Routes = [
  { path: '', component: PantallaPrincipalComponent },
  { path: 'pantalla', component: PantallaComponent },
  { path: 'pantallaOperacion', component: PantallaOperacionesComponent},
  { path: 'pantallaBalance' , component : PantallaBalanceComponent},
  { path: 'pantallaRetiro' , component : PantallaRetiroComponent},
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
