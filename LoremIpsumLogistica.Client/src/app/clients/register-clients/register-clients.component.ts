import { Component, OnInit } from '@angular/core';
import { Clients } from 'src/app/models/clients';
import { ClientsService } from 'src/app/services/clients.service';

@Component({
  selector: 'app-register-clients',
  templateUrl: './register-clients.component.html',
  styleUrls: ['./register-clients.component.css']
})
export class RegisterClientsComponent implements OnInit {

  client: Clients = { firstName: "", lastName: "", birthDate: "", genre:"" };
 
  constructor(
    private clientsService: ClientsService
  ) { }

  ngOnInit(): void {
  }
  save() {
    console.log(this.client)
    this.clientsService.postClients(this.client)
      .subscribe(
        (c: Clients) => {

        },
        (err) => {
          console.log(err);
        }
      )
  }

  cancel() {

  }

}
