import { EmployeeMonthlyTotalOrderAndDeductionsService } from 'src/app/shared/services/employee-monthly-total-order-and-deductions.service';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import * as moment from 'moment';
import { EmployeeOrder, IEmployee } from 'src/app/shared/models/employee/employee';

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

  orders:any;
  selectedDate : Date;
  employeeOrder : EmployeeOrder = new EmployeeOrder();
  constructor( public dialogRef: MatDialogRef<NewEmployeeOrderDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,
  private fb : FormBuilder,
  private employeeService : EmployeeService,
  private orderService :OrderService,
  private monthlyEmployeeOrderService :EmployeeMonthlyTotalOrderAndDeductionsService

  ){
   const dateNow = new Date();
   this.selectedDate = new Date( dateNow.setHours(dateNow.getHours()+2));

  }
  ngOnInit(): void {
    console.log(this.data);

    this.employeeForm=this.IntilizeEmployeeForm();
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
    .subscribe(x =>{
      this.employee=x;
      this.employeeOrder.employeeId=x.id;
      this.orderService.getAllOrders().subscribe(x => this.orders=x)
      this.orderForm=this.IntilizeOrderForm();



      console.log(this.orderForm);
    });


  }


  IntilizeOrderForm(){
    return this.fb
    .group({
      selectedDate : [this.selectedDate],
      employeeId:[this.employeeOrder.employeeId],
      orderNumber:[this.employeeOrder.orderNumber],
      details:[this.employeeOrder.details],
      employeeOrderType:this.fb.group({
        orderId:[this.employeeOrder.employeeOrderType.orderId],
        quantity:[this.employeeOrder.employeeOrderType.quantity],
        creditOrDebit :[this.employeeOrder.employeeOrderType.creditOrDebit],
        amount:[this.employeeOrder.employeeOrderType.amount],
        formId :[this.data.formId]
      })
    });


  }
  orderSubmit(){
  this.employeeOrder = Object.assign({...this.employeeOrder},this.orderForm.value)

  // if(this.employeeOrder.startFrom || this.employeeOrder.endAt){
  //   this.employeeOrder.startFrom= moment(this.employeeOrder.startFrom).toDate()
  //   this.employeeOrder.endAt= moment(this.employeeOrder.endAt).toDate()

  // }

  console.log(this.employeeOrder);
this.monthlyEmployeeOrderService.postNewOrder(this.employeeOrder).subscribe(x => this.onNoClick());
  }
  // calculateQuantity(ev){
  //   const dat1= moment(this.orderForm.value.startFrom);
  //   const date2= moment(this.orderForm.value.endAt);
  //   const dateDiff=date2.diff(dat1,'days')+1;
  //   this.employeeOrder.quantity=dateDiff;
  //    this.orderForm.patchValue({quantity:dateDiff});
  // }
}
