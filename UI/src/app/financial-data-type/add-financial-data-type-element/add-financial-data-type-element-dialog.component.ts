import { stat } from 'fs';
import { FinancialDataTypeParam } from './../../shared/models/param';
import { FinancialDataTypeService } from './../../shared/services/financial-data-type.service';
import { Component, Inject, OnInit, AfterViewInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FinancialDataType } from 'src/app/shared/models/employee/employee';
import * as moment from 'moment';

@Component({
  selector: 'app-add-financial-data-type-element',
  templateUrl: './add-financial-data-type-element-dialog.component.html',
  styleUrls: ['./add-financial-data-type-element-dialog.component.scss']
})
export class AddFinancialDataTypeElementDialogComponent implements OnInit ,AfterViewInit {

  form : FormGroup;

  model : FinancialDataType;
  financialDataTypes:FinancialDataType[];
  constructor( public dialogRef: MatDialogRef<AddFinancialDataTypeElementDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
   private fb : FormBuilder,
   private financialDataTypeService:FinancialDataTypeService
    ){}
  ngAfterViewInit(): void {


  }
  ngOnInit(): void {
    console.log(this.data);
    this.loadFinancialDataTypes();
    this.model= this.data.model;
    this.form=this.initilizeForm();
  }

  loadFinancialDataTypes(){
    this.financialDataTypeService.getAllFinicialDataType(new FinancialDataTypeParam()).subscribe((x:any) =>
      {
        this.financialDataTypes=x.value;
      }
      );
  }
  initilizeForm (){

    return this.fb.group({

      name:[this.model.name,Validators.required],
      parentFinancialDataTypeId:[this.model.parentFinancialDataTypeId,Validators.required],
      reservationDate :[this.model.reservationDate,Validators.required]
    });
  }
  onNoClick(){

    this.dialogRef.close();
  }
  changeFinicialData(ev){

    this.model.parentFinancialDataTypeId=ev;
  }
  dateChange(ev){

    let time  = moment( ev.target.value._d,'YYYY-MM-DD').add(2,'hours');
    this.form.get('reservationDate').setValue(time.toISOString());
  }
  onSubmit(){
   this.model= Object.assign(this.model,this.form.value)

    if(this.data.state==='add'){
   this.financialDataTypeService.postFinicialDataType(this.model).subscribe(x => this.dialogRef.close())
  }
  if(this.data.state==='edit'){
    this.financialDataTypeService.putFinicialDataType(this.model).subscribe(x => this.dialogRef.close())
   }
  }
}
