import { Collection } from './../../../shared/models/employee/employee';
import { CollectionService } from './../../../shared/services/collection.service';
import { EmployeeCollectionService } from './../../../shared/services/employee-collection.service';
import { EmployeeFormService } from './../../../shared/services/employee-form.service';
import { Component, Inject, AfterViewInit, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-add-employee-form-collection-dialog',
  templateUrl: './add-employee-form-collection-dialog.component.html',
  styleUrls: ['./add-employee-form-collection-dialog.component.scss']
})
export class AddEmployeeFormCollectionDialogComponent implements OnInit, AfterViewInit {
  form : FormGroup;
  collectoins :Collection[];
  selectedCollection:Collection;
  constructor(public dialogRef: MatDialogRef<AddEmployeeFormCollectionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private employeeFormService :EmployeeFormService,
    private employeeCollectionmService : EmployeeCollectionService,
    private collectionService : CollectionService
    ) {
  }
  ngOnInit(): void {
    this.form=this.initilizerForm();
  }
  ngAfterViewInit(): void {
    this.collectionService.getAllCollections().subscribe((x:Collection[]) => this.collectoins=x);

  }
  initilizerForm (){
    return this.fb.group({

      collection:['']
    });
  }
  onNoClick(){
    this.dialogRef.close();
  }
  onSubmit(){

    this.employeeFormService.PostEmployeeCollection({collectionId:this.selectedCollection,formId:this.data.formId})
    .subscribe(x => this.onNoClick());
  }
}
