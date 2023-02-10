import { BankBranchesService } from './../../../shared/services/bank-branches.service';
import { BankBranch } from './../../../shared/models/employee/employee';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-add-branch-dialog',
  templateUrl: './add-branch-dialog.component.html',
  styleUrls: ['./add-branch-dialog.component.scss']
})
export class AddBranchDialogComponent {
  form:FormGroup;
  model : BankBranch= new BankBranch();
  constructor (public dialogRef: MatDialogRef<AddBranchDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private branchService :BankBranchesService,
  ){}
  ngOnInit(): void {
    if(this.data.state==='edit'){

      this.model=this.data.model;
    }
    else{
      this.model=new BankBranch();
      this.model.bankId= this.data.model.bankId
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
    this.branchService.postBankBranch(this.model).subscribe(x =>{
      this.onNoClick();
    })
  }
  else{

    this.branchService.updateBankBranch(this.model).subscribe(x =>{
      this.onNoClick();
    })
  }
}
}
