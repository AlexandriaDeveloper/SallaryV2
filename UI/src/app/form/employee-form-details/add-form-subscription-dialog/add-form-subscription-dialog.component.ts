import { EmployeeFormService } from 'src/app/shared/services/employee-form.service';
import { CheckedSucription, EmployeeForm, FinancialYear, IEmployee } from './../../../shared/models/employee/employee';
import { SubscriptionService } from './../../../shared/services/subscription.service';
import { Component, Inject, AfterViewInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Sucription } from 'src/app/shared/models/employee/employee';
import { MatCheckboxChange } from '@angular/material/checkbox';

@Component({
  selector: 'app-add-form-subscription-dialog',
  templateUrl: './add-form-subscription-dialog.component.html',
  styleUrls: ['./add-form-subscription-dialog.component.scss']
})
export class AddFormSubscriptionDialogComponent implements AfterViewInit {

  subsriptions : CheckedSucription[]

  constructor(public dialogRef: MatDialogRef<AddFormSubscriptionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
   private subscriptionService :SubscriptionService,
   private employeeFormService : EmployeeFormService
   ) {


  }

  // checkChange(ev:MatCheckboxChange ){

  //   this.subsriptions.findIndex(x => x=== ev.source.value)

  // }
  ngAfterViewInit(): void {
  this.employeeFormService.getCheckedSubscription(this.data.formId).subscribe((x:CheckedSucription[]) => this.subsriptions=x);
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  onSubmit(){

    this.employeeFormService.postEmployeeSubscription(this.data.formId,this.subsriptions).subscribe(x =>  this.onNoClick())
  }


  
}
