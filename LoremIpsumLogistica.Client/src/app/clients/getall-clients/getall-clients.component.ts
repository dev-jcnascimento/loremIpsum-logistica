import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { ClientEdit, Clients } from 'src/app/models/clients';
import { MatTableDataSource } from '@angular/material/table';
import { ClientsService } from 'src/app/services/clients.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { DialogEditClientsComponent } from 'src/app/dialog-edit-clients/dialog-edit-clients.component';

@Component({
  selector: 'app-getall-clients',
  templateUrl: './getall-clients.component.html',
  styleUrls: ['./getall-clients.component.css']
})

export class GetallClientsComponent implements AfterViewInit, OnInit {



  constructor(
    private clientsService: ClientsService,
    private snackbar: MatSnackBar,
    private dialog: MatDialog
  ) { }


  displayedColumns: string[] = ['fullName', 'birthDateString', 'genre', 'actionsDelete', 'actionsEdit'];
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
  editTicket(c: Clients) {
    
    let newClient: Clients = Object.assign({}, c);
    let dialogRef = this.dialog.open(DialogEditClientsComponent, { width: '400px', data: newClient });
    dialogRef.afterClosed()
      .subscribe((res) => {
        let client: ClientEdit = {
          id: res.id ,
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
            (err) => console.error(err)
          )
        }
      });
    }

  buscar() {
        this.clientsService.getAllClients()
          .subscribe(data => {
            this.dataSource.data = data;
          }
          );

      }
  notify(msg: string) {
        this.snackbar.open(msg, "OK", { duration: 3000 });
      }
}


