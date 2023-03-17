import { AddEmployeeElementDialogComponent } from './add-employee-element-dialog/add-employee-element-dialog.component';
import { FinancialDataType } from 'src/app/shared/models/employee/employee';
import { FinancialDataTypeService } from './../../../../shared/services/financial-data-type.service';
import { DatePipe } from '@angular/common';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import * as moment from 'moment';
import { FinancialDataTypeParam, GetEmployeeElementDetailsParam } from 'src/app/shared/models/param';
import { EmployeeBasicFinicialDataService } from 'src/app/shared/services/employee-basic-finicial-data.service';

@Component({
  selector: 'app-balance-element-details-dialog',
  templateUrl: './balance-element-details-dialog.component.html',
  styleUrls: ['./balance-element-details-dialog.component.scss'],
  providers:[DatePipe]
})
export class BalanceElementDetailsDialogComponent implements OnInit, AfterViewInit {
/**
 *
 */

param :GetEmployeeElementDetailsParam = new GetEmployeeElementDetailsParam();
items;
form : FormGroup;

finicialDataTypes :FinancialDataType[]=[];
constructor(
  public dialogRef: MatDialogRef<BalanceElementDetailsDialogComponent>,
@Inject(MAT_DIALOG_DATA) public data: any,
 private fb : FormBuilder,
 private datePipe :DatePipe,
 private employeeBasicFinicialDataService:EmployeeBasicFinicialDataService,
 private FinicialDataTypeService:FinancialDataTypeService,

 public dialog: MatDialog
 ) {

}
  ngAfterViewInit(): void {
    //throw new Error('Method not implemented.');
    this.form= this.initialForm();

  }
  ngOnInit(): void {

  let  param = new FinancialDataTypeParam();
  param.financialDataTypesId=this.data.finicialDataTypeId;
this.FinicialDataTypeService.getAllFinicialDataType(param).subscribe((
  x:FinancialDataType[]) => {this.finicialDataTypes=x;console.log(x)}

  )

    this.param.employeeId=this.data.employeeId;
    this.param.finicialDataTypeId=this.data.finicialDataTypeId;
    this.param.reservationDate=this.data.date;
    this.loadData();


  }

  loadData(){
    this.employeeBasicFinicialDataService.GetEmployeeElementDetailsQuery(this.param).subscribe((x:any) =>{
      this.items=x;
      this.form= this.initialForm();
      this.initialFormArray();
    });

  }
  initialForm(){

  return this.fb.group({

      employeeFinicialElementData: this.fb.array([])

    });


  }

initialFormArray() {
  this.items.employeeFinicialElementDataDto.forEach(element => {
    console.log(element);
  this.getFormControls().push(this.createElement(element));

});
return this.getFormControls().controls;
}


createElement(el){
  return  this.fb.group({
      id:[el.id],
      name: [el.name],
      amount : [el.amount],
      reservationDate:[this.datePipe.transform( el.reservationDate,'MM-dd-yyyy')]

    })
  }


  createNewElement(){

    this.getFormControls().push(this.createElement({id:0,name:'',amount :0,reservationDate:new Date()}));
  }
  onNoClick(){

    this.dialogRef.close();
  }


  getFormControls() :FormArray{
    return this.form.get('employeeFinicialElementData') as FormArray ;
  }

  onSubmit(){

  }

  deleteItem(item, index){
   if(confirm(`انت على وشك حذف البيان ${item.value.name} هل انت متأكد ؟!`))
   {
    let c :any =this.getFormControls();
    let elementToDelete = c.controls.splice( [index],1).value;
   this.employeeBasicFinicialDataService.deleteEmployeeFincialElementById(item.value.id).subscribe(x => {
    this.loadData();});
  }
}



 openNewDialog(){
//   let time  = moment(this.selectedDate).toISOString();

//   let param = new GetEmployeeElementDetailsParam();
//   param.reservationDate=moment().toISOString();
  const dialogRef = this.dialog.open(AddEmployeeElementDialogComponent, {
   data: { financialDataTypesId:this.param.finicialDataTypeId,employeeId : this.param.employeeId},
    minWidth:'600px',
   hasBackdrop:true,
   disableClose:true
  });

  dialogRef.afterClosed().subscribe(result => {
    //this.animal = result;
   this.loadData();
  });
}

UpdateEmployeeFinicialElementData(item){
console.log(item.value);
 this.employeeBasicFinicialDataService.updateEmployeeFincialElementById({id:item.value.id ,amount : item.value.amount}).subscribe(
  x => this.loadData());
}
}
