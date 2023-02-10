import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeFormService } from './../../../shared/services/employee-form.service';
import { SubscriptionService } from './../../../shared/services/subscription.service';
import { EmployeeSubscription, Sucription } from './../../../shared/models/employee/employee';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, AfterViewInit, OnInit } from '@angular/core';

@Component({
  selector: 'app-upload-susbcription-file',
  templateUrl: './upload-susbcription-file.component.html',
  styleUrls: ['./upload-susbcription-file.component.scss']
})
export class UploadSusbcriptionFileComponent implements AfterViewInit ,OnInit {
form : FormGroup;
subscriptions : Sucription[];
formId : number;
/**
 *
 */
constructor(
  private activetedRoute : ActivatedRoute,
  private router : Router,
  private fb : FormBuilder,
  private subscriptionService :SubscriptionService
  ,private employeeForm : EmployeeFormService) {

}
  ngOnInit(): void {
   // throw new Error('Method not implemented.');

   this.formId= this.activetedRoute.snapshot.params['id'];
   this.form= this.initilizeForm();

  }
  ngAfterViewInit(): void {
   // throw new Error('Method not implemented.');

   this.subscriptionService.getSubsriptionsList().subscribe((x:Sucription[]) => this.subscriptions= x);

  }
  upload(event){
  const file :File = event[0];
  console.log(file);

  this.form.get('file').setValue(file);


}

deleteElement(){

  let subId =this.form.get('subscriptionId').value;
this.employeeForm.deleteFormSubscriptionElement(this.formId,subId).subscribe( x =>{
  this.router.navigateByUrl('form/form-details/'+this.formId);
  });

}
  initilizeForm (){
    return this.fb.group({
      subscriptionId :[Validators.required],
      file:[Validators.required]
    });
  }


onSubmit(){
console.log(this.form.value);
let model ={
formId : this.formId,
subscriptionId : this.form.get('subscriptionId').value,
file :   this.form.get('file').value

}
this.employeeForm.uploadSubscriptionElement(model).subscribe( x=> console.log('uploaded'))

}
}
