import { FinancialDataTypeParam } from 'src/app/shared/models/param';
import { FinancialDataTypeService } from './../../../../../shared/services/financial-data-type.service';
import { EmployeeDataFinancialDataType, FinancialDataType } from 'src/app/shared/models/employee/employee';
import { Component, Inject, OnInit, AfterViewInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { EmployeeBasicFinicialDataService } from 'src/app/shared/services/employee-basic-finicial-data.service';

@Component({
  selector: 'app-add-employee-element-dialog',
  templateUrl: './add-employee-element-dialog.component.html',
  styleUrls: ['./add-employee-element-dialog.component.scss']
})
export class AddEmployeeElementDialogComponent implements OnInit,AfterViewInit {
  param =new  FinancialDataTypeParam();
  financialDataTypes :FinancialDataType[];

  employeeDataFinancialDataType :EmployeeDataFinancialDataType= new EmployeeDataFinancialDataType();
  form : FormGroup;
  /**
   *
   */
  constructor(
    public dialogRef: MatDialogRef<AddEmployeeElementDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,
   private fb : FormBuilder,
   private financialDataTypeService :FinancialDataTypeService,
   private employeeBasicFinicialDataService :EmployeeBasicFinicialDataService

   ) {


this.loadData()
  }
  ngAfterViewInit(): void {
   // throw new Error('Method not implemented.');
  }
  ngOnInit(): void {
    this.employeeDataFinancialDataType.employeeId=this.data.employeeId;


    this.form=this.initilizeForm();
  }

  loadData(){
    this.param.financialDataTypesId=this.data.financialDataTypesId;

    this.financialDataTypeService.getAllFinicialDataType(this.param).subscribe((x:any) => {
      this.financialDataTypes=x.value
    })
  }

  initilizeForm (){
    return this.fb.group({
      financialDataTypeId:[this.employeeDataFinancialDataType.financialDataTypeId],
      amount : [this.employeeDataFinancialDataType.amount],
      employeeId:[this.employeeDataFinancialDataType.employeeId]

    })

  }
  onNoClick(){
  this.dialogRef.close();
  }

  onSubmit(){

   this.employeeDataFinancialDataType= Object.assign(this.employeeDataFinancialDataType,this.form.value);
    console.log(this.employeeDataFinancialDataType)
  this.employeeBasicFinicialDataService.postEmployeeElement(this.employeeDataFinancialDataType).subscribe(x => this.dialogRef.close());
  }
}
