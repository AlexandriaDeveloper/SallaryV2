import { OrderFile } from './../../../shared/models/employee/employee';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-order-file-dialog',
  templateUrl: './add-order-file-dialog.component.html',
  styleUrls: ['./add-order-file-dialog.component.scss']
})
export class AddOrderFileDialogComponent implements OnInit {
  form:FormGroup;
  model : OrderFile= new OrderFile();
  constructor (public dialogRef: MatDialogRef<AddOrderFileDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private orderFileService :OrderFileService,
  ){}
  ngOnInit(): void {
    this.form =this.InitilizeForm();
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  InitilizeForm (){
  return  this.fb.group({
      details : [this.model.details,[Validators.required]]

    });
  }
  onSubmit(){
    Object.assign(this.model, this.form.value)
    this.orderFileService.postOrderFile(this.model).subscribe(x =>{
      this.onNoClick();
    })

  }
}
