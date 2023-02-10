import { Component, Inject, AfterViewInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { PeriodicSubscriptionHistory } from 'src/app/shared/models/employee/employee';
import { PeriodicSubscriptionService } from 'src/app/shared/services/periodic-subscription.service';

@Component({
  selector: 'app-subscription-history-dialog',
  templateUrl: './subscription-history-dialog.component.html',
  styleUrls: ['./subscription-history-dialog.component.scss']
})
export class SubscriptionHistoryDialogComponent implements AfterViewInit {
/**
 *
 */
periodicSubscriptionHistory  :PeriodicSubscriptionHistory[];
constructor(public dialogRef: MatDialogRef<SubscriptionHistoryDialogComponent>,
  @Inject(MAT_DIALOG_DATA) public data: any,

 // private activatedRoute :ActivatedRoute,

  private periodicSubscriptionService: PeriodicSubscriptionService) {


}
  ngAfterViewInit(): void {
    this.periodicSubscriptionService
    .getHistoryPeriodicSubscription(this.data.employeeId,this.data.subscriptionId)
    .subscribe((x:PeriodicSubscriptionHistory[]) => {
      this.periodicSubscriptionHistory=x;
    })
  }
}

