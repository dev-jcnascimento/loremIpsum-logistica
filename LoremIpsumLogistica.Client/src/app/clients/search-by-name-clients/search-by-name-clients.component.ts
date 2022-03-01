import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatTableDataSource } from '@angular/material/table';
import { DialogAddressComponent } from 'src/app/addresses/dialog-address/dialog-address.component';
import { DialogEditClientsComponent } from 'src/app/dialog-edit-clients/dialog-edit-clients.component';
import { Addresses } from 'src/app/models/addresses';
import { ClientEdit, Clients } from 'src/app/models/clients';
import { AddressesService } from 'src/app/services/addresses.service';
import { ClientsService } from 'src/app/services/clients.service';

@Component({
  selector: 'app-search-by-name-clients',
  styleUrls: ['./search-by-name-clients.component.css'],
  templateUrl: './search-by-name-clients.component.html',
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ]
})
export class SearchByNameClientsComponent implements AfterViewInit {

  public firstname: string = '';
  public lastname: string = '';

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


  displayedColumns: string[] = ['fullName', 'birthDateString', 'genre', 'actionsDelete', 'actionsEdit', 'actionsEnd'];
  dataSource = new MatTableDataSource<Clients>();
  expandedElement: Clients | null | undefined;




  ngAfterViewInit() {
  }

  getByName() {
    console.log(this.firstname)
    this.clientsService.getByNameClients(this.firstname, this.lastname)
      .subscribe(data => {
        this.dataSource.data = data;
      });
  }


  deleteTicket(rowid: string) {
    this.clientsService.deleteClients(rowid)
      .subscribe(
        () => this.notify("Deleted!"),
        (err) => console.log(err),
        () => this.getByName()
      );
  }
  editTicket(c: Clients) {

    let newClient: Clients = Object.assign({}, c);
    let dialogRef = this.dialog.open(DialogEditClientsComponent, { width: '400px', data: newClient });
    dialogRef.afterClosed()
      .subscribe((res) => {
        let client: ClientEdit = {
          id: res.id,
          firstName: res.firstName,
          lastName: res.lastName,
          birthDate: res.birthDate,
          genre: res.genre
        };
        console.log(client)
        if (client) {
          this.clientsService.putClients(client)
            .subscribe(
              () => this.notify("Salvo!"),
              (err) => console.error(err),
              () => this.getByName()
            )
        }
      });
  }
  addEnd(c: Clients) {
    
    this.address.clientId = c.id
    this.address.clienteName = c.fullName
    this.address.typeAddress = "Commercial"
    this.address.zipCode = ""
    this.address.place = ""
    this.address.number = ""
    this.address.district = ""
    this.address.state = ""
    this.address.complement = ""

    let dialogAddressRef = this.dialog.open(DialogAddressComponent, { width: '600px', data: this.address });
    dialogAddressRef.afterClosed()
      .subscribe((res) => {
        if (res) {
          this.addressService.postAddresses(res)
            .subscribe(
              () => this.notify("Salvo!"),
              (err) => console.error(err),
              () => this.getByName()
            )            
        }
      });

  }

  notify(msg: string) {
    this.snackbar.open(msg, "OK", { duration: 4000 });
  }
}