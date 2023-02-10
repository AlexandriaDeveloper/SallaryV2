import { SubscriptionService } from './../../../shared/services/subscription.service';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Sucription } from 'src/app/shared/models/employee/employee';

@Component({
  selector: 'app-add-subscription',
  templateUrl: './add-subscription.component.html',
  styleUrls: ['./add-subscription.component.scss']
})
export class AddSubscriptionComponent {
  form:FormGroup;
  model : Sucription= new Sucription();
  constructor(public dialogRef: MatDialogRef<AddSubscriptionComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private subscriptionService :SubscriptionService){}

    ngOnInit(): void {
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
      this.subscriptionService.postSubsription(this.model).subscribe(x =>{
        this.onNoClick();
      })

    }
}
