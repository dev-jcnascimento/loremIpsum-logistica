import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule }   from '@angular/forms';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material.module';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { TapGroupClientsComponent } from './clients/tap-group-clients/tap-group-clients.component';
import { RegisterClientsComponent } from './clients/register-clients/register-clients.component';
import { GetallClientsComponent } from './clients/getall-clients/getall-clients.component';
import { SearchByNameClientsComponent } from './clients/search-by-name-clients/search-by-name-clients.component';
import { DialogEditClientsComponent } from './dialog-edit-clients/dialog-edit-clients.component';
import { GetaddressByClientComponent } from './addresses/getaddress-by-client/getaddress-by-client.component';
import { DialogAddressComponent } from './addresses/dialog-address/dialog-address.component';


@NgModule({
  declarations: [
    AppComponent,
    PageNotFoundComponent,
    TapGroupClientsComponent,
    RegisterClientsComponent,
    GetallClientsComponent,
    SearchByNameClientsComponent,
    DialogEditClientsComponent,
    GetaddressByClientComponent,
    DialogAddressComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents:[
    DialogEditClientsComponent,
    DialogAddressComponent
  ],
})
export class AppModule { }
