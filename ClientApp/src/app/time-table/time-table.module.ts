import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {ClasseComponent} from './classe/classe.component';
import {HttpClientModule} from '@angular/common/http';
import {Class} from './classe';
import {TimeTableRepository} from './time-table.repository';

@NgModule({
  declarations: [ClasseComponent],
  imports: [BrowserModule, HttpClientModule],
  exports: [ClasseComponent],
  providers: [Class, TimeTableRepository]
})
export class TimeTableModule {}
