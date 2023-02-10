import { state } from '@angular/animations';
import { AddEmployeeSubscription, EmployeeSubscription } from './../../../shared/models/employee/employee';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IEmployee } from 'src/app/shared/models/employee/employee';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { EmployeeSubsriptionService } from 'src/app/shared/services/employee-subsription.service';
import { EmployeeSubsriptionParam } from 'src/app/shared/models/param';

@Component({
  selector: 'app-add-employee-to-subscription',
  templateUrl: './add-employee-to-subscription.component.html',
  styleUrls: ['./add-employee-to-subscription.component.scss']
})
export class AddEmployeeToSubscriptionComponent {
  employeeForm:FormGroup;
  subscriptionForm:FormGroup;
  employee: IEmployee;
  notExistMessage=false
  model : AddEmployeeSubscription= new AddEmployeeSubscription();
  constructor (public dialogRef: MatDialogRef<AddEmployeeToSubscriptionComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeService : EmployeeService,
    private EmployeeSubscriptionService :EmployeeSubsriptionService,
  ){}
  ngOnInit(): void {

    if(this.data.state==='edit'){
      console.log(this.data)
      this.employeeService.getEmployee(this.data.row.employeeId).subscribe(x =>{ this.employee=x;this.model.employeeId=x.id});

      this.EmployeeSubscriptionService.getEmployeeSubscriptionById(this.data.row.id).subscribe((x:AddEmployeeSubscription) => {
        this.model=x
      console.log(this.model)
      this.subscriptionForm= this.InitilizeForm();
  });

    }


    this.employeeForm =this.IntilizeEmployeeForm();
    this.model.subscriptionId=this.data.subscriptionId;
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  IntilizeEmployeeForm(){

    return this.fb.group({
      tabCode:[''],
      tegaraCode:['']

    })
  };
  InitilizeForm (){
  return  this.fb.group({
    employeeId:[this.model.employeeId],
    subscriptionId:[this.model.subscriptionId],
     amount : [this.model.amount,[Validators.required]],
     details : [this.model.details,[]]

    });
  }
  onSubmitEmployee(){
    this.employee=null;
    this.employeeService
    .findEmployeeByTabCodeOrTegaraCode(this.employeeForm.value.tabCode,this.employeeForm.value.tegaraCode)
    .subscribe(
      {next:(x : IEmployee)=>{

       this.employee=x;
       this.model.employeeId=x.id,
        this.notExistMessage=false;
        this.subscriptionForm=this.InitilizeForm();
      },
      error:(err )=> {
        this.employee=null;
        this.notExistMessage=true;
      }});
  }
  onAddEmployeeToSubscription(){
    // if(this.employee){


    Object.assign(this.model,this.subscriptionForm.value)
    if(this.data.state==='edit'){
      this.EmployeeSubscriptionService.updateEmployeeSubscrtiption(this.model).subscribe(x =>{

        this.dialogRef.close();
      })

    }
    else{
         this.EmployeeSubscriptionService.addEmployeeToSubscription(this.model).subscribe(x =>

        this.dialogRef.close()
      );

    }
  }
}
