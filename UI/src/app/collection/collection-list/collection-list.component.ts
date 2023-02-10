import { CollectionService } from './../../shared/services/collection.service';
import { CollectionListDataSource } from './collection-list-dataSource';
import { Collection } from './../../shared/models/employee/employee';
import { AddCollectionDialogComponent } from './add-collection-dialog/add-collection-dialog.component';
import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';

@Component({
  selector: 'app-collection-list',
  templateUrl: './collection-list.component.html',
  styleUrls: ['./collection-list.component.scss']
})
export class CollectionListComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<Collection>;
   dataSource: CollectionListDataSource;
  // orderFileParam :OrderFileParam= new OrderFileParam();

  displayedColumns = ['action', 'name'];
constructor(public dialog: MatDialog, private collectionService : CollectionService){}
  ngAfterViewInit(): void {



    this.dataSource = new CollectionListDataSource(this.collectionService, this.paginator);
   // this.table.dataSource = this.dataSource.connect();

    this.table.dataSource = this.dataSource;
    this.paginator=this.dataSource.paginator;
  }
  openDialog(){
    const dialogRef = this.dialog.open(AddCollectionDialogComponent, {
     // data: {name: this.name, animal: this.animal},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.table.dataSource = this.dataSource.connect();
     // this.animal = result;
    });
  }
}
