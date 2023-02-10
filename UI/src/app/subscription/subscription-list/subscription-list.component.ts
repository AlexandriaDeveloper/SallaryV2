import { EmployeeSubsriptionService } from 'src/app/shared/services/employee-subsription.service';
import { AddSubscriptionComponent } from './add-subscription/add-subscription.component';
import { SubscriptionService } from './../../shared/services/subscription.service';
import { SubscriptionListDataSource } from './subscription-list-dataSource';
import { Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { Sucription } from 'src/app/shared/models/employee/employee';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-subscription-list',
  templateUrl: './subscription-list.component.html',
  styleUrls: ['./subscription-list.component.scss']
})
export class SubscriptionListComponent {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<Sucription>;
   dataSource: SubscriptionListDataSource;
  // orderFileParam :OrderFileParam= new OrderFileParam();

  displayedColumns = ['action', 'name'];
constructor(public dialog: MatDialog, private subscriptionService : SubscriptionService){}
  ngAfterViewInit(): void {



    this.dataSource = new SubscriptionListDataSource(this.subscriptionService, this.paginator);
   // this.table.dataSource = this.dataSource.connect();
    this.table.dataSource = this.dataSource;
    this.paginator=this.dataSource.paginator;
  }
  openDialog(){
    const dialogRef = this.dialog.open(AddSubscriptionComponent, {
     // data: {name: this.name, animal: this.animal},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.table.dataSource = this.dataSource.connect();
     // this.animal = result;
    });
  }


}
