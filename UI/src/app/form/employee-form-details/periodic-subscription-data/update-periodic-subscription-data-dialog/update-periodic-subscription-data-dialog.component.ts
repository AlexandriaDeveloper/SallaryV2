import { PeriodicSubscriptionService } from 'src/app/shared/services/periodic-subscription.service';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-update-periodic-subscription-data-dialog',
  templateUrl: './update-periodic-subscription-data-dialog.component.html',
  styleUrls: ['./update-periodic-subscription-data-dialog.component.scss']
})
export class UpdatePeriodicSubscriptionDataDialogComponent implements AfterViewInit, OnInit {
/**
 *
 */
form :FormGroup;
dataModel:any
constructor(public dialogRef: MatDialogRef<UpdatePeriodicSubscriptionDataDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,

  private fb : FormBuilder,private periodicSubscriptionService : PeriodicSubscriptionService) {

}
  ngOnInit(): void {
    this.dataModel=this.data.model;
   this.form=this.initialForm()
  }
initialForm (){
  return this.fb.group({

    amount :[this.dataModel.amount,Validators.required]
  })
}
  ngAfterViewInit(): void {

  }
  onNoClick(){

    this.dialogRef.close();
  }
  submit(){
 Object.assign(this.dataModel,this.form.value);
 this.periodicSubscriptionService.updatePeriodicSubscriptionById(this.dataModel).subscribe();
 this.onNoClick()
  }
}
