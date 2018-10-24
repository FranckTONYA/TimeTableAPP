import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {NavbarComponent} from './navbar/navbar.component';
import {AlertComponent} from './alert/alert.component';
import {Alert} from './alert';
import {RouterModule} from '@angular/router';

@NgModule({
  declarations: [NavbarComponent, AlertComponent],
  exports: [NavbarComponent, AlertComponent],
  imports: [BrowserModule, RouterModule],
  providers: [Alert]
})
export class  CoreModule {}
