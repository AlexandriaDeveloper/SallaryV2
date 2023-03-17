import { EmployeeVacationTypeService } from './../../../../shared/services/employee-vacation-type.service';
import { EmployeeVacation } from './../../../../shared/models/employee/employee';
import { VacationTypeService } from './../../../../shared/services/vacation-type.service';
import { Component, Inject, OnInit, AfterViewInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { NewEmployeeOrderDialogComponent } from '../new-employee-order-dialog/new-employee-order-dialog.component';
import { GetVacationTypeParam } from 'src/app/shared/models/param';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { IEmployee, FinancialYear, EmployeeOrder } from 'src/app/shared/models/employee/employee';
import { FinancialYearService } from 'src/app/shared/services/financial-year.service';
import { OrderService } from 'src/app/shared/services/order.service';
import * as moment from 'moment';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';

@Component({
  selector: 'app-employee-vacation-dialog',
  templateUrl: './employee-vacation-dialog.component.html',
  styleUrls: ['./employee-vacation-dialog.component.scss']
})
export class EmployeeVacationDialogComponent implements OnInit,AfterViewInit {

  vacationTypeParam = new GetVacationTypeParam();
  employeeForm:FormGroup;
  employeeVacationForm:FormGroup;
  employee: IEmployee;
  financialYears:FinancialYear[];
  employeeVacation : EmployeeVacation = new EmployeeVacation();
  selectedFinancialYear : FinancialYear;
vacationTypes =[];

  constructor( public dialogRef: MatDialogRef<NewEmployeeOrderDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
   private fb : FormBuilder,
   private vacationTypeService:VacationTypeService,

  private employeeService : EmployeeService,
  private employeeVacationService: EmployeeVacationTypeService,
  private orderService :OrderService,
   ) {


  }
  ngOnInit(): void {

    console.log(this.data)
   this.vacationTypeService.getAllVacationType(this.vacationTypeParam).subscribe((x:any) => this.vacationTypes=x);

   this.employeeVacation.formId= this.data.formId
   this.employeeForm=this.IntilizeEmployeeForm();

  }

  IntilizeEmployeeForm(){

    return this.fb.group({
      tabCode:[''],
      tegaraCode:['']

    });

    }
  ngAfterViewInit(): void {
   // throw new Error('Method not implemented.');
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  submitEmployee(){
    this.employeeService
    .findEmployeeByTabCodeOrTegaraCode(this.employeeForm.value.tabCode,this.employeeForm.value.tegaraCode)
    .subscribe((x:IEmployee )=>{
      this.employee=x;
      this.employeeVacation.employeeId=x.id;

      console.log(this.employeeVacation)
      this.employeeVacationForm=this.IntilizeOrderForm();
    });

     // this.financialYearService.getAllFinancialYears().subscribe((x:FinancialYear[]) => {this.financialYears=x;console.log(x)});
     // this.orderService.getAllOrders().subscribe(x => this.orders=x)




    //this.orderForm.get('financialYearId').setValue(this.selectedFinancialYear.id)


  }

  IntilizeOrderForm(){
    console.log(this.employeeVacation)
    return this.fb
    .group({

      vacationId:[this.employeeVacation.vacationId],
      orderNumber:[this.employeeVacation.orderNumber],
      details:[this.employeeVacation.details],
      quantity:[this.employeeVacation.quantity],
      creditOrDebit :[this.employeeVacation.creditOrDebit],
      startAt:[this.employeeVacation.startAt ],
      endAt:[this.employeeVacation.endAt],

    });
  }
  startAtDateChange(ev ){

    let startDate = moment(ev.value._d).hours(2).toISOString();
    console.log(this.employeeVacationForm.value);
console.log(startDate);
  this.employeeVacationForm.patchValue({startAt:startDate})
  }

  endAtDateChange(ev){

    let endDate = moment(ev.value._d).hours(2).toISOString();
   this.employeeVacationForm.patchValue({endAt:endDate})
  }
  vacationFormSubmit(){

    console.log(this.employeeVacationForm.value);
   this.employeeVacation= Object.assign(this.employeeVacation,this.employeeVacationForm.value)

    this.employeeVacationService.addNewEmployeeVacationType(this.employeeVacation).subscribe(x => this.onNoClick());
  }
}
