import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { MaterialModule } from './material/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TableSearchBoxComponent } from './components/table-search-box/table-search-box.component';
import { DateAdapter, MAT_DATE_FORMATS } from '@angular/material/core';
import { MomentDateAdapter } from '@angular/material-moment-adapter';

export const DateFormats = {
  parse: {
      dateInput: ['DD/MM/YYYY'] //D = Days, M = Months, Y = Years. you can change the input format
  },
  display: {
      dateInput: 'DD/MM/YYYY',
      monthYearLabel: 'MMM YYYY',
      dateA11yLabel: 'LL',
      monthYearA11yLabel: 'MMMM YYYY',
  }
};

@NgModule({
  declarations: [
    NavbarComponent,
    TableSearchBoxComponent,
  ],
  imports: [
    CommonModule,
    RouterModule,
    MaterialModule

  ],
  exports:[MaterialModule,
    NavbarComponent,
    TableSearchBoxComponent,
     ReactiveFormsModule,

  ],providers: [

    { provide: DateAdapter, useClass: MomentDateAdapter},
    { provide: MAT_DATE_FORMATS, useValue: DateFormats },

]
})
export class SharedModule { }
