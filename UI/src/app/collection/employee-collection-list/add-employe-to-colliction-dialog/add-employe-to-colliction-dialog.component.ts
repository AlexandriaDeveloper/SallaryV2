import { EmployeeCollectionService } from './../../../shared/services/employee-collection.service';

import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { IEmployee } from 'src/app/shared/models/employee/employee';
import { CollectionService } from 'src/app/shared/services/collection.service';
import { EmployeeService } from 'src/app/shared/services/employee.service';

@Component({
  selector: 'app-add-employe-to-colliction-dialog',
  templateUrl: './add-employe-to-colliction-dialog.component.html',
  styleUrls: ['./add-employe-to-colliction-dialog.component.scss']
})
export class AddEmployeToCollictionDialogComponent implements OnInit {
  employeeForm:FormGroup;
  employee: IEmployee;
  notExistMessage=false
 // model : Collection= new Collection();
  constructor (public dialogRef: MatDialogRef<AddEmployeToCollictionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeeService : EmployeeService,
    private employeeCollectionService :EmployeeCollectionService,
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
      this.employeeCollectionService.postEmployeeToCollection({employeeId : this.employee.id,collectionId:this.data.collectionId}).subscribe(x =>

        this.dialogRef.close()
      );
    }

  }
}

