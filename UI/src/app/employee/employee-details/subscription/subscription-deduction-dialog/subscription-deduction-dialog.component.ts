import { PeriodicSubscriptionService } from './../../../../shared/services/periodic-subscription.service';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit, AfterViewInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { PeriodicSubscription } from 'src/app/shared/models/employee/employee';

@Component({
  selector: 'app-subscription-deduction-dialog',
  templateUrl: './subscription-deduction-dialog.component.html',
  styleUrls: ['./subscription-deduction-dialog.component.scss']
})
export class SubscriptionDeductionDialogComponent implements OnInit,AfterViewInit {
  orderForm:FormGroup;
   model : PeriodicSubscription= new PeriodicSubscription();
   formId;
  // deductionOrder= new DeductionOrder();
  constructor (public dialogRef: MatDialogRef<SubscriptionDeductionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private activatedRoute :ActivatedRoute,

    private periodicSubscriptionService: PeriodicSubscriptionService
   // private employeeOrderDeductionService :EmployeeOrderDeductionService,
    // private employeeService : EmployeeService,
    // private financialYearService: FinancialYearService,
    // private orderService :OrderService,
    // private monthlyEmployeeOrderService :EmployeeMonthlyTotalOrderAndDeductionsService

  ){}
  ngOnInit(): void {
    this.orderForm=this.IntilizeOrderForm();


    // this.deductionOrder.employeeId=this.data.employeeId;
    // this.deductionOrder.orderId= this.data.orderId;
  }
  ngAfterViewInit(): void {
   this.orderForm=this.IntilizeOrderForm();

   this.activatedRoute.queryParams.subscribe((x:any) => {
    this.formId=x.formId;


  });
  }


  IntilizeOrderForm(){
    return this.fb.group({
      amount:['',Validators.required]

    });

    }
  onNoClick(): void {
    this.dialogRef.close();
  }
  onSubmit(){
   Object.assign(this.data,this.orderForm.value);


  this.periodicSubscriptionService.addPeriodicSubscriptionDto(this.data).subscribe(x => this.onNoClick())


    // this.employeeOrderDeductionService.postEmployeeDeduction(this.deductionOrder).subscribe(x => this.onNoClick());
  }
}
