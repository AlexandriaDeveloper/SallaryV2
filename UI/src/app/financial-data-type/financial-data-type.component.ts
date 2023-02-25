import { AddFinancialDataTypeElementDialogComponent } from './add-financial-data-type-element/add-financial-data-type-element-dialog.component';
import { FinancialDataTypeParam } from './../shared/models/param';
import { FinancialDataTypeService } from './../shared/services/financial-data-type.service';
import { Component, AfterViewInit } from '@angular/core';
import * as moment from 'moment';
import { MatDialog } from '@angular/material/dialog';
import { FinancialDataType } from '../shared/models/employee/employee';
import { stat } from 'fs';
import { Clipboard } from '@angular/cdk/clipboard';
@Component({
  selector: 'app-financial-data-type',
  templateUrl: './financial-data-type.component.html',
  styleUrls: ['./financial-data-type.component.scss']
})
export class FinancialDataTypeComponent implements AfterViewInit {
/**
 *
 */
parents : FinancialDataType[];
subs:FinancialDataType[];

selectedFinancialDataType:FinancialDataType;
param : FinancialDataTypeParam = new FinancialDataTypeParam();
showCopyMessage=false;
constructor(public dialog :MatDialog,private financialDataTypeService :FinancialDataTypeService, private clipboard: Clipboard) {

}
  ngAfterViewInit(): void {
    this.loadData();
  }

  loadData(){
    this.financialDataTypeService.getAllFinicialDataType(this.param).subscribe((x:any) =>
      {
        this.parents=x.value;
      }
      );
  }

  loadSubData(){
    this.financialDataTypeService.getAllFinicialDataType(this.param).subscribe((x:any) =>
    {
      this.subs=x.value;
    }
   );

  }
  changeSub(ev){
    this.param.financialDataTypesId=ev.value;
    this.loadSubData()
  }
  dateChange(ev){
    let time  = moment( ev.target.value._d,'YYYY-MM-DD').add(2,'hours');
     this.param.reservationDate=time.toISOString();
    this.loadSubData()
  }

  openDialog(state : string , finincialDataType? : FinancialDataType ): void {

console.log(this.param.financialDataTypesId);

    if(state === 'add'){
      this.selectedFinancialDataType= new FinancialDataType();
     this.selectedFinancialDataType.parentFinancialDataTypeId= this.param.financialDataTypesId;
    }
    else if(state==='edit'){
      this.selectedFinancialDataType=finincialDataType;

    }


    const dialogRef = this.dialog.open(AddFinancialDataTypeElementDialogComponent, {
      data: {state : state, model : this.selectedFinancialDataType},

      minWidth:'600px',
     // minHeight:'759px',
      disableClose:true,
      panelClass:['dialog']
    });

    dialogRef.afterClosed().subscribe(result => {
      //this.animal = result;
     this.loadSubData();
    });
  }
  deleteFinancialDataTypes(row :FinancialDataType){
  if(  confirm(`انت على وشك حذف العنصر ${row.name} هل انت متأكد `)){

    this.financialDataTypeService.deleteFinicialDataType(row.id).subscribe(x => this.loadSubData());
  }
  }

  copyToClipboard(id){
    this.showCopyMessage=true;
    this.clipboard.copy(id);
    setTimeout(() => {
      this.showCopyMessage=false;
    }, 3000);
    //this.showCopyMessage=false;
  }
}
