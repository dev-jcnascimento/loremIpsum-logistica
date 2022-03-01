import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DialogAddressComponent } from 'src/app/addresses/dialog-address/dialog-address.component';
import { Addresses } from 'src/app/models/addresses';
import { Clients } from 'src/app/models/clients';
import { AddressesService } from 'src/app/services/addresses.service';
import { ClientsService } from 'src/app/services/clients.service';

@Component({
  selector: 'app-register-clients',
  templateUrl: './register-clients.component.html',
  styleUrls: ['./register-clients.component.css']
})
export class RegisterClientsComponent implements OnInit {

  client: Clients = { firstName: "", lastName: "", birthDate: "", genre: "Male" };

  address: Addresses = {
    typeAddress: "Commercial",
    zipCode: "",
    place: "",
    number: "",
    complement: "",
    district: "",
    state: "",
    clientId: "",
    clienteName: ""
  };


  constructor(
    private clientsService: ClientsService,
    private addressService: AddressesService,
    private snackbar: MatSnackBar,
    private dialog: MatDialog
  ) { }

  ngOnInit(): void {
  }
  save() {
    console.log(this.client)
    this.clientsService.postClients(this.client)
      .subscribe(
        (c: Clients) => {
          this.address.clientId = c.id,
            this.address.clienteName = c.fullName
        },
        (err) => {
          console.log(err)},
          () => this.notify("Salvo!"),
      );
  }

  addEnd() {
    let dialogAddressRef = this.dialog.open(DialogAddressComponent, { width: '600px', data: this.address });
    dialogAddressRef.afterClosed()
      .subscribe((res) => {
        if (res) {
          this.addressService.postAddresses(res)
            .subscribe(
              () => this.notify("Salvo!"),
              (err) => console.error(err)
            )
        }
      });
  }
  notify(msg: string) {
    this.snackbar.open(msg, "OK", { duration: 5000 });
  }

}
