import { EmployeeFormService } from 'src/app/shared/services/employee-form.service';
import { SubscriptionService } from './../../../../shared/services/subscription.service';

import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AddEmployeeSubscription, CheckedSucription, IEmployee, PeriodicSubscription } from 'src/app/shared/models/employee/employee';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { PeriodicSubscriptionService } from 'src/app/shared/services/periodic-subscription.service';
import { concatMap, map } from 'rxjs';

@Component({
  selector: 'app-add-employee-periodic-form-dialog',
  templateUrl: './add-employee-periodic-form-dialog.component.html',
  styleUrls: ['./add-employee-periodic-form-dialog.component.scss']
})
export class AddEmployeePeriodicFormDialogComponent implements OnInit, AfterViewInit {
  employeeSubscriptionForm : FormGroup;
  subscriptions : CheckedSucription[];
  model: PeriodicSubscription = new PeriodicSubscription();
  employeeForm:FormGroup;
  employee: IEmployee;
  notExistMessage=false
  employeeNotExistMessage=false;
constructor(
  public dialogRef: MatDialogRef<AddEmployeePeriodicFormDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,
  private fb : FormBuilder,
  private employeeService : EmployeeService,
  private subscriptionService :SubscriptionService,
  private employeeFormSrvice : EmployeeFormService,
  private periodicSubscriptionService : PeriodicSubscriptionService){}
  ngOnInit(): void {

    this.subscriptionService.getSubsriptionsList().subscribe((x:CheckedSucription[]) => this.subscriptions=x)

    this.employeeForm= this.IntilizeEmployeeForm();
    console.log(this.data)


  }
  ngAfterViewInit(): void {
   // throw new Error('Method not implemented.');
   console.log(+this.data.formId)
   this.model.formId=+this.data.formId;
  }


  initialForm(){

    return this.fb.group({
      subscriptionId:[,Validators.required],
      amount:[Validators.required]
    });
  }
  IntilizeEmployeeForm(){

    return this.fb.group({
      tabCode:[''],
      tegaraCode:['']

    })
  };
  onNoClick(){
    this.dialogRef.close();
  }
  onSubmitEmployee(){
    this.employee=null;
    this.employeeService


    .findEmployeeByTabCodeOrTegaraCode(this.employeeForm.value.tabCode,this.employeeForm.value.tegaraCode).pipe(
      map((x:IEmployee )=> {
        console.log(x);
        this.employee=x;
        this.model.employeeId=x.id;
         this.notExistMessage=false;
      }),
      concatMap((emp:any) => this.employeeFormSrvice.checkEmployeeExistInForm(this.employee.id, this.data.formId) )
    )
    .subscribe(
      {next:(x )=>{
        console.log(x)
        if(x ===false){
          this.employeeNotExistMessage=true;
          this.employee=null;
          this.employeeSubscriptionForm=this.initialForm();
        }
        else{

          this.employeeNotExistMessage=false;
        }


      },
      error:(err )=> {
        console.log('err',err)
        this.employee=null;
        this.notExistMessage=true;
      }});

      this.employeeSubscriptionForm=this.initialForm();
  }
  submit(){
    console.log(this.employeeSubscriptionForm.value);

    Object.assign(this.model,this.employeeSubscriptionForm.value);
    console.log(this.model);

    this.periodicSubscriptionService.addEmployeeToPeriodicSubscription(this.model).subscribe( x=> this.onNoClick());

  }
}
