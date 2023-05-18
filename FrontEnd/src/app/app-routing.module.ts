import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PantallaComponent } from './pantalla/pantalla.component';
import { PantallaPrincipalComponent } from './pantalla-principal/pantalla-principal.component';

const routes: Routes = [
  { path: '', component: PantallaPrincipalComponent },
  { path: 'pantalla', component: PantallaComponent },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
