import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Addresses } from 'src/app/models/addresses';

@Component({
  selector: 'app-dialog-address',
  templateUrl: './dialog-address.component.html',
  styleUrls: ['./dialog-address.component.css']
})
export class DialogAddressComponent implements OnInit {

  address: Addresses = {
    id: "",
    typeAddress: "",
    zipCode: "",
    place: "",
    number:"",
    complement:"",
    district:"",
    state:"",
    clientId:""
  };

  clientName ?: string = '';

  constructor(public dialogAddressRef: MatDialogRef<DialogAddressComponent>,
    @Inject(MAT_DIALOG_DATA) public a: Addresses){
      this.address = a,
      this.clientName = a.clienteName;
    }

  ngOnInit(): void {
  }

  cancel(){
    this.dialogAddressRef.close();
  }
}
