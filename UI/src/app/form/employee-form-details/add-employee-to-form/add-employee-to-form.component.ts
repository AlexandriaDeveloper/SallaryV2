import { EmployeeFormService } from './../../../shared/services/employee-form.service';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IEmployee } from 'src/app/shared/models/employee/employee';
import { EmployeeService } from 'src/app/shared/services/employee.service';

@Component({
  selector: 'app-add-employee-to-form',
  templateUrl: './add-employee-to-form.component.html',
  styleUrls: ['./add-employee-to-form.component.scss']
})
export class AddEmployeeToFormComponent implements OnInit {
  employeeForm:FormGroup;
  employee: IEmployee;
  notExistMessage=false
 // model : Collection= new Collection();
  constructor (public dialogRef: MatDialogRef<AddEmployeeToFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeService : EmployeeService,
    private employeeFormService :EmployeeFormService,
  ){}
  ngOnInit(): void {
    this.employeeForm =this.IntilizeEmployeeForm();
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
   //   name : [this.model.name,[Validators.required]]

    });
  }
  onSubmitEmployee(){
    this.employee=null;
    this.employeeService
    .findEmployeeByTabCodeOrTegaraCode(this.employeeForm.value.tabCode,this.employeeForm.value.tegaraCode)
    .subscribe(
      {next:(x : IEmployee)=>{
       this.employee=x;
        this.notExistMessage=false;
      },
      error:(err )=> {
        this.employee=null;
        this.notExistMessage=true;
      }});
  }
  onAddEmployee(){
    if(this.employee){
     this.employeeFormService.postEmployeeToForm({employeeId : this.employee.id,formId:+this.data.formId}).subscribe(x =>

       this.dialogRef.close()
     );
    }

  }
}
