import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {ClasseRepository} from './classe.repository';
import {ListClasseComponent} from './list/list.classe.component';
import {HttpClientModule} from '@angular/common/http';
import {CoreModule} from '../core/core.module';
import {DisplayClasseComponent} from './display/display.classe.component';
import {RouterModule} from '@angular/router';

@NgModule({
  imports: [BrowserModule, HttpClientModule, CoreModule, RouterModule],
  providers: [ClasseRepository],
  declarations: [ListClasseComponent, DisplayClasseComponent],
  exports: [ListClasseComponent]
})
export class ClasseModule {}
