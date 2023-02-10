import { ActivatedRoute } from '@angular/router';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DeductionOrder, OrderFile } from 'src/app/shared/models/employee/employee';
import { EmployeeOrderDeductionService } from 'src/app/shared/services/employee-order-deduction.service';
import { OrderFileService } from 'src/app/shared/services/order-file.service';

@Component({
  selector: 'app-pay-deduction-dialog',
  templateUrl: './pay-deduction-dialog.component.html',
  styleUrls: ['./pay-deduction-dialog.component.scss']
})
export class PayDeductionDialogComponent implements OnInit, AfterViewInit {
  orderForm:FormGroup;
  model : OrderFile= new OrderFile();
  deductionOrder= new DeductionOrder();
  formId:number;
  constructor (public dialogRef: MatDialogRef<PayDeductionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeOrderDeductionService :EmployeeOrderDeductionService,
    private activatedRoute:ActivatedRoute

  ){}
  ngOnInit(): void {
    this.orderForm=this.IntilizeOrderForm();
    this.deductionOrder.employeeId=this.data.employeeId;
    this.deductionOrder.orderId= this.data.orderId;


    this.activatedRoute.queryParams.subscribe ((x:any) => this.formId=x.formId);
  }
  ngAfterViewInit(): void {
   this.orderForm=this.IntilizeOrderForm();
  }


  IntilizeOrderForm(){
    return this.fb.group({
      details:[''],
      amount:['',Validators.required]

    });

    }
  onNoClick(): void {
    this.dialogRef.close();
  }
  onSubmit(){
    Object.assign(this.deductionOrder,this.orderForm.value);
    this.deductionOrder.formId=this.formId;
    this.employeeOrderDeductionService.postEmployeeDeduction(this.deductionOrder).subscribe(x => this.onNoClick());
  }
}
