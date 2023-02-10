import { FormService } from './../../../shared/services/form.service';
import { Component, Inject, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Form } from 'src/app/shared/models/employee/employee';
import { DateAdapter, MAT_DATE_FORMATS, MAT_DATE_LOCALE } from '@angular/material/core';
import { MAT_MOMENT_DATE_ADAPTER_OPTIONS, MomentDateAdapter } from '@angular/material-moment-adapter';
import { MatDatepicker } from '@angular/material/datepicker';
export const MY_FORMATS = {
  parse: {
    dateInput: 'MM/YYYY',
  },
  display: {
    dateInput: 'MM/YYYY',
    monthYearLabel: 'MMM YYYY',
    dateA11yLabel: 'LL',
    monthYearA11yLabel: 'MMMM YYYY',
  },
};
@Component({
  selector: 'app-add-form-dialog',
  templateUrl: './add-form-dialog.component.html',
  styleUrls: ['./add-form-dialog.component.scss'],
  providers: [
    // `MomentDateAdapter` can be automatically provided by importing `MomentDateModule` in your
    // application's root module. We provide it at the component level here, due to limitations of
    // our example generation script.
    {
      provide: DateAdapter,
      useClass: MomentDateAdapter,
      deps: [MAT_DATE_LOCALE, MAT_MOMENT_DATE_ADAPTER_OPTIONS],
    },

    {provide: MAT_DATE_FORMATS, useValue: MY_FORMATS},
  ],
})
export class AddFormDialogComponent {

  form:FormGroup;
  model : Form= new Form();
  @ViewChild('date') date;
  constructor (public dialogRef: MatDialogRef<AddFormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private formService :FormService,
  ){}
  ngOnInit(): void {
    this.form =this.InitilizeForm();
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  InitilizeForm (){
  return  this.fb.group({
      details : [this.model.details,[Validators.required]],
      fileNumber224 : [this.model.fileNumber224,[]],
      fileNumber55 : [this.model.fileNumber55,[]],
      formDate : [this.model.formDate,[]],


    });
  }
  onSubmit(){

    Object.assign(this.model, this.form.value)
    this.formService.postForm(this.model).subscribe(x =>{
      this.onNoClick();
    })

  }
  setMonthAndYear(normalizedMonthAndYear: any, datepicker: MatDatepicker<any>) {
    // const ctrlValue = this.date.value!;
    // ctrlValue.month(normalizedMonthAndYear.month());
    // ctrlValue.year(normalizedMonthAndYear.year());
    // this.date.setValue(ctrlValue);
//this.model.fromDate=normalizedMonthAndYear.month
let month = +normalizedMonthAndYear.month();
let monthDate = '';

if(month >=9)
{
  monthDate= (month+1).toString();

}
else{
  monthDate='0'+(month+1).toString();
}

//let month = +normalizedMonthAndYear.month()//+1
const year = +normalizedMonthAndYear.year()
const dateFrom = year.toString()+'-'+ monthDate.toString();
this.form.get('formDate').setValue(dateFrom) ;
this.model.formDate=(dateFrom);

    datepicker.close();
  }
}
