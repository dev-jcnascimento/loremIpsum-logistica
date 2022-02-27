import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { Clients } from 'src/app/models/clients';
import { MatTableDataSource } from '@angular/material/table';
import { ClientsService } from 'src/app/services/clients.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-getall-clients',
  templateUrl: './getall-clients.component.html',
  styleUrls: ['./getall-clients.component.css']
})

export class GetallClientsComponent implements AfterViewInit, OnInit {



  constructor(
    private clientsService: ClientsService,
    private snackbar: MatSnackBar
    ) { }


  displayedColumns: string[] = ['fullName', 'birtDate', 'genre', 'actionsDelete', 'actionsEdit'];
  dataSource = new MatTableDataSource<Clients>();

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    

  }
  ngOnInit(): void {
    
  }
  deleteTicket(rowid: string) {
    this.clientsService.deleteClients(rowid)
    .subscribe(
      () => this.notify("Deleted!"),
      (err) => console.log(err),
      () => this.ngAfterViewInit()
      
    );
  }
  editTicket(rowid: number) {
   
  }
  buscar() {
    this.clientsService.getAllClients()
      .subscribe(data => {
        this.dataSource.data = data;
      }
      );
    this.clientsService.getAllClients()
      .subscribe(data => console.log(data)
      );
   
  }
  notify(msg: string){
    this.snackbar.open(msg, "OK", {duration: 3000});
  }
}


