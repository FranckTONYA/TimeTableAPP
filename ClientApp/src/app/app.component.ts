import { Component } from '@angular/core';
import {Alert} from './core/alert';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private alert: Alert) {
    this.alert.success('message', 5000);
  }
  title = 'ClientApp';
}
