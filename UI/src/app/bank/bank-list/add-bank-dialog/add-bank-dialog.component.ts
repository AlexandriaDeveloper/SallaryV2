import { state } from '@angular/animations';
import { PostEmployeeBank } from './../../../shared/models/employee/employee';
import { BankService } from './../../../shared/services/bank.service';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Bank } from 'src/app/shared/models/employee/employee';

@Component({
  selector: 'app-add-bank-dialog',
  templateUrl: './add-bank-dialog.component.html',
  styleUrls: ['./add-bank-dialog.component.scss']
})
export class AddBankDialogComponent {
  form:FormGroup;
  model : Bank= new Bank();
  constructor (public dialogRef: MatDialogRef<AddBankDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private bankService :BankService,
  ){}
  ngOnInit(): void {
    if(this.data.state==='edit'){

      this.model=this.data.bank;
    }
    else{
      this.model=new Bank();
    }



    this.form =this.InitilizeForm();
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  InitilizeForm (){
  return  this.fb.group({
      name : [this.model.name,[Validators.required]]

    });
  }
  onSubmit(){



    Object.assign(this.model, this.form.value)
  if(this.data.state ==='add')
  {
    this.bankService.postBank(this.model).subscribe(x =>{
      this.onNoClick();
    })
  }
  else{

    this.bankService.updateBank(this.model).subscribe(x =>{
      this.onNoClick();
    })
  }
}
}
