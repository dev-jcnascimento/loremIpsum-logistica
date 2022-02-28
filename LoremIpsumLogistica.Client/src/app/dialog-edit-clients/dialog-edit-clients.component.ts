import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ClientEdit, Clients } from '../models/clients';

@Component({
  selector: 'app-dialog-edit-clients',
  templateUrl: './dialog-edit-clients.component.html',
  styleUrls: ['./dialog-edit-clients.component.css']
})
export class DialogEditClientsComponent implements OnInit {

client: ClientEdit = {
  id:'',
  firstName:'',
  lastName:'',
  birthDate: '',
  genre: ''
};

  constructor( public dialogRef: MatDialogRef<DialogEditClientsComponent>,
    @Inject(MAT_DIALOG_DATA) public c: ClientEdit){
      this.client = c;
    }

  ngOnInit(): void {
  }

  cancel(){
    this.dialogRef.close();
  }
}
