import { EmployeePartTimeService, } from '../../../../shared/services/employee-part-time.service';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import * as moment from 'moment';
import { EmployeePartTime } from 'src/app/shared/models/employee/employee';

@Component({
  selector: 'app-employee-part-time-dialog',
  templateUrl: './employee-part-time-dialog.component.html',
  styleUrls: ['./employee-part-time-dialog.component.scss'],
})

//create your own formats

export class EmployeePartTimeDialogComponent implements AfterViewInit , OnInit {
form : FormGroup;
model :EmployeePartTime= new EmployeePartTime();
  /**
   *
   */
  constructor(public dialogRef: MatDialogRef<EmployeePartTimeDialogComponent>,
     @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,
    private employeePartTimeService: EmployeePartTimeService
) {


  }
  ngOnInit(): void {
    console.log(this.data.employee)
   if(this.data.employee.employeeInPartTime ===true){
    this.employeePartTimeService.getEmployeePartTimeByEmployeeId(this.data.employee.id)
    .subscribe((x:EmployeePartTime) => {
    this.model=x;
    console.log(this.model)
    this.form= this.initilizeForm();
  });

  }
  else{
this.model.employeeId=this.data.employee.id;
    //this.form= this.initilizeForm();

  }
  this.form= this.initilizeForm();

  }
  ngAfterViewInit(): void {

  }

initilizeForm (){
  return this.fb.group({

    startFrom :[this.model.startFrom,Validators.required],
    details :[this.model.details],
    endAt:[this.model.endAt]

  });
}

  onNoClick(){
    this.dialogRef.close();
  }
  onSubmit(){

    this.model= Object.assign(this.model,this.form.value);
    this.model.startFrom= moment(this.form.value.startPartTime).toDate();
    this.model.endAt= moment(this.form.value.endAt).toDate();
    console.log(this.model)
    if(this.data.employee.employeeInPartTime===false){
      this.employeePartTimeService.employeeStartPartTime(this.model).subscribe(x=>this.onNoClick());
    }
    else{
      this.employeePartTimeService.updateStartPartTime(this.model).subscribe(x=>this.onNoClick());
    }

  }
}
