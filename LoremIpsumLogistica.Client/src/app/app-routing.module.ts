import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { RouterModule, Routes } from '@angular/router';
import { GetallClientsComponent } from './clients/getall-clients/getall-clients.component';
import { RegisterClientsComponent } from './clients/register-clients/register-clients.component';

const appRoutes: Routes = [
  {path:'getall-clients', component: GetallClientsComponent},
  {path:'register-clients', component: RegisterClientsComponent},
  {path:'**', component: PageNotFoundComponent},

]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(appRoutes)
  ],
  exports:[
    RouterModule
  ]
})
export class AppRoutingModule { }
