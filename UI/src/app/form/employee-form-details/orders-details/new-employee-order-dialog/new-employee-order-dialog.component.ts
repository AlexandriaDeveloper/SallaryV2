import { EmployeeMonthlyTotalOrderAndDeductionsService } from 'src/app/shared/services/employee-monthly-total-order-and-deductions.service';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import * as moment from 'moment';
import { EmployeeOrder, FinancialYear, IEmployee } from 'src/app/shared/models/employee/employee';
import { FinancialYearService } from 'src/app/shared/services/financial-year.service';
import { OrderService } from 'src/app/shared/services/order.service';

@Component({
  selector: 'app-new-employee-order-dialog',
  templateUrl: './new-employee-order-dialog.component.html',
  styleUrls: ['./new-employee-order-dialog.component.scss']
})
export class NewEmployeeOrderDialogComponent implements OnInit {
  employeeForm:FormGroup;
  orderForm:FormGroup;
  employee: IEmployee;
  financialYears:FinancialYear[];
  orders:any;
  selectedFinancialYear : FinancialYear;
  employeeOrder : EmployeeOrder = new EmployeeOrder();
constructor( public dialogRef: MatDialogRef<NewEmployeeOrderDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,
 private fb : FormBuilder,
private employeeService : EmployeeService,
private financialYearService: FinancialYearService,
private orderService :OrderService,
private monthlyEmployeeOrderService :EmployeeMonthlyTotalOrderAndDeductionsService

  ){}
  ngOnInit(): void {
    console.log(this.data)
    this.employeeOrder.formId= this.data.formId
   this.employeeForm=this.IntilizeEmployeeForm();
   this.financialYearService.getLastFinancialYear().subscribe((x:FinancialYear) => {this.selectedFinancialYear=x;
    this.employeeOrder.financialYearId=x.id;});
   //this.employeeOrder.orderFileId= this.data.orderFileId
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
IntilizeEmployeeForm(){

return this.fb.group({
  tabCode:[''],
  tegaraCode:['']

});

}
  submitEmployee(){
  this.employeeService
    .findEmployeeByTabCodeOrTegaraCode(this.employeeForm.value.tabCode,this.employeeForm.value.tegaraCode)
    .subscribe(x =>{this.employee=x;this.employeeOrder.employeeId=x.id;console.log(x)})
   ;

      this.financialYearService.getAllFinancialYears().subscribe((x:FinancialYear[]) => {this.financialYears=x;console.log(x)});
      this.orderService.getAllOrders().subscribe(x => this.orders=x)


    this.orderForm=this.IntilizeOrderForm();

    this.orderForm.get('financialYearId').setValue(this.selectedFinancialYear.id)

  }


  IntilizeOrderForm(){

    return this.fb
    .group({

     // employeeId:[this.employeeOrder.employeeId],
      orderFileId:[this.employeeOrder.orderFileId],
      financialYearId :[this.employeeOrder.financialYearId,Validators.required],
      orderId:[this.employeeOrder.orderId],
      orderNumber:[this.employeeOrder.orderNumber],
      details:[this.employeeOrder.details],
      amount:[this.employeeOrder.amount],
      quantity:[this.employeeOrder.quantity],
      creditOrDebit :[this.employeeOrder.creditOrDebit],
      startFrom:[this.employeeOrder.startFrom ],
      endAt:[this.employeeOrder.endAt]



    });
  }
  orderSubmit(){
  Object.assign(this.employeeOrder,this.orderForm.value)

  if(this.employeeOrder.startFrom || this.employeeOrder.endAt){
    this.employeeOrder.startFrom= moment(this.employeeOrder.startFrom).toDate()
    this.employeeOrder.endAt= moment(this.employeeOrder.endAt).toDate()

  }

  console.log(this.employeeOrder);
this.monthlyEmployeeOrderService.postNewOrder(this.employeeOrder).subscribe(x => this.onNoClick());
  }
  calculateQuantity(ev){
    const dat1= moment(this.orderForm.value.startFrom);
    const date2= moment(this.orderForm.value.endAt);
    const dateDiff=date2.diff(dat1,'days')+1;
    this.employeeOrder.quantity=dateDiff;
     this.orderForm.patchValue({quantity:dateDiff});
  }
}
