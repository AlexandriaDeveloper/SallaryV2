import { CollectionService } from './../../../shared/services/collection.service';
import { Collection } from './../../../shared/models/employee/employee';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-add-collection-dialog',
  templateUrl: './add-collection-dialog.component.html',
  styleUrls: ['./add-collection-dialog.component.scss']
})
export class AddCollectionDialogComponent {
  form:FormGroup;
  model : Collection= new Collection();
  constructor (public dialogRef: MatDialogRef<AddCollectionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb : FormBuilder,

    private collectionService :CollectionService,
  ){}
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


    this.collectionService.postCollection(this.model).subscribe(x =>{
      this.onNoClick();
    })

  }
}
