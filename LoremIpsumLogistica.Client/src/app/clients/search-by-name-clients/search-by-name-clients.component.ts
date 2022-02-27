import { Component, OnInit, AfterViewInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatTableDataSource } from '@angular/material/table';
import { Clients } from 'src/app/models/clients';
import { ClientsService } from 'src/app/services/clients.service';

@Component({
  selector: 'app-search-by-name-clients',
  templateUrl: './search-by-name-clients.component.html',
  styleUrls: ['./search-by-name-clients.component.css']
})
export class SearchByNameClientsComponent implements AfterViewInit {

  public firstname: string = '';
  public lastname: string = '';

  constructor(
    private clientsService: ClientsService,
    private snackbar: MatSnackBar,
  ) { }

  displayedColumns: string[] = ['fullName', 'birtDate', 'genre', 'actionsDelete', 'actionsEdit'];
  dataSource = new MatTableDataSource<Clients>();



  ngAfterViewInit() {
    this.clientsService.getByNameClients(this.firstname, this.lastname)
      .subscribe(data => {
        this.dataSource.data = data;
      });
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
      );
  }

  notify(msg: string) {
    this.snackbar.open(msg, "OK", { duration: 3000 });
  }
}