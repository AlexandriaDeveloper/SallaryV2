import { switchMap } from 'rxjs';
import { FormEmployeeOrderExecutionsParam } from './../../../../shared/models/param';
import { FormEmployeeOrderExecutionsService } from './../../../../shared/services/form-employee-order-executions.service';
import { ActivatedRoute } from '@angular/router';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DeductionOrder, FormEmployeeOrder, OrderFile } from 'src/app/shared/models/employee/employee';
import { EmployeeOrderDeductionService } from 'src/app/shared/services/employee-order-deduction.service';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { FormEmployeeService } from 'src/app/shared/services/form-employee.service';

@Component({
  selector: 'app-pay-deduction-dialog',
  templateUrl: './pay-deduction-dialog.component.html',
  styleUrls: ['./pay-deduction-dialog.component.scss']
})
export class PayDeductionDialogComponent implements OnInit, AfterViewInit {
  orderForm:FormGroup;
  model : OrderFile= new OrderFile();
  //deductionOrder= new DeductionOrder();
  deductionOrder = new FormEmployeeOrder();
  param :FormEmployeeOrderExecutionsParam = new FormEmployeeOrderExecutionsParam();
  formId:number;
  formEmployeeOrderExecutions:[];
  constructor (public dialogRef: MatDialogRef<PayDeductionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeOrderDeductionService :EmployeeOrderDeductionService,
    private activatedRoute:ActivatedRoute,
    private formEmployeeOrderDeductionService : FormEmployeeOrderExecutionsService,
    private formEmployeeService :FormEmployeeService

  ){}
  ngOnInit(): void {
    this.orderForm=this.IntilizeOrderForm();
    this.deductionOrder.orderId= this.data.employeeFormOrderId;
    this.activatedRoute.queryParams.subscribe ((x:any) => this.formId=x.formId);
    this.param.orderId= this.data.orderId;
    this.param.employeeId= this.data.employeeId;
    this.formEmployeeOrderDeductionService.getBy(this.param).subscribe((x:[]) => {
      this.formEmployeeOrderExecutions=x
      this.orderForm=this.IntilizeOrderForm();
      this.initilizeFomrArray();
    });


  }
  ngAfterViewInit(): void {


  }


  IntilizeOrderForm(){



    return this.fb.group({
      details:[''],
      formEmployeeId:[],
      orderId:[this.param.orderId],
      formEmployeeOrderExecutions :this.fb.array([])

    });

    }

    initilizeFomrArray() {
      this.formEmployeeOrderExecutions.forEach(element => {
      this.getFormEmployeeOrderExections.push(this.createElements(element));
    });
    }
  onNoClick(): void {
    this.dialogRef.close();
  }
  onSubmit(){

    Object.assign(this.deductionOrder,this.orderForm.value);
    let orderCall = this.formEmployeeService.getFormEmployeeByFormIdAndEmployeeId(this.formId,this.data.employeeId);
    let employeeOrderDeductionCall = orderCall.pipe(switchMap(( value:any ) => {
      this.deductionOrder.formEmployeeId= value.id;
     return this.employeeOrderDeductionService.postEmployeeDeduction(this.deductionOrder)

    }));
    employeeOrderDeductionCall.subscribe(x => this.onNoClick());
  }

  get getFormEmployeeOrderExections()  {
    return this.orderForm.get("formEmployeeOrderExecutions") as FormArray
  }

  createElements(element){
return this.fb.group({
  amount:[element.amount],
  budgetItemName : [element.budgetItemName],
  budgetItemId : [element.budgetItemId],
  formEmployeeOrderId : [element.formEmployeeOrderId],
});
}
}
