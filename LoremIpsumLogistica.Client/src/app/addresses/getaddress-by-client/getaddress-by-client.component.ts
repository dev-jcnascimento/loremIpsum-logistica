import { AfterViewInit, Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatTableDataSource } from '@angular/material/table';
import { Addresses } from 'src/app/models/addresses';
import { AddressesService } from 'src/app/services/addresses.service';
import { DialogAddressComponent } from '../dialog-address/dialog-address.component';

@Component({
  selector: 'app-getaddress-by-client',
  templateUrl: './getaddress-by-client.component.html',
  styleUrls: ['./getaddress-by-client.component.css']
})
export class GetaddressByClientComponent implements OnInit, AfterViewInit {

  @Input() clientId: string = '';

  constructor(
    private addressesService: AddressesService,
    private snackbar: MatSnackBar,
    private dialog: MatDialog
  ) { }

  displayedColumns: string[] = [
    'typeAddress',
    'zipCode',
    'place',
    'number',
    'complement',
    'district',
    'state',
    'actionsDelete',
    'actionsEdit'];
  dataSource = new MatTableDataSource<Addresses>();

  ngOnInit(): void {
    console.log(this.clientId)

  }

  teste(clientId: string) {
    this.addressesService.getAddressesByClient(clientId)
      .subscribe(data => {
        this.dataSource.data = data;
        console.log(data)
      }
      );
  }

  deleteTicket(rowid: string) {
    this.addressesService.deleteAddresses(rowid)
      .subscribe(
        () => this.notify("Deleted!"),
        (err) => console.log(err),
        () => this.ngAfterViewInit()

      );
  }
  editTicket(d: Addresses) {

    let newAddress: Addresses = Object.assign({}, d);
    let dialogRef = this.dialog.open(DialogAddressComponent, { width: '600px', data: newAddress });
    dialogRef.afterClosed()
      .subscribe((res) => {
        // let client: ClientEdit = {
        //   id: res.id ,
        //   firstName: res.firstName,
        //   lastName: res.lastName,
        //   birthDate: res.birthDate,
        //   genre: res.genre
        // };
        console.log(res)
        if (res) {
          this.addressesService.putAddresses(res)
          .subscribe(
            () => this.notify("Salvo!"),
            (err) => console.error(err),
            () => this.ngAfterViewInit()
          )
        }
      });
    }


  ngAfterViewInit() {
    if (this.clientId != null) {

      console.log(this.clientId)
      this.addressesService.getAddressesByClient(this.clientId)
        .subscribe(data => {
          this.dataSource.data = data;
          console.log(data);
        });
    }
  }

  notify(msg: string) {
    this.snackbar.open(msg, "OK", { duration: 5000 });
  }
}
