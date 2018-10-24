import {Component} from '@angular/core';
import {Alert} from '../alert';

@Component({
  selector: 'app-alert',
  templateUrl: 'alert.component.html'
})
export class AlertComponent {
  message: string;
  className: string;
  show = true;

  constructor(private alert: Alert) {
    this.alert.alert.subscribe(a => {
      this.message = a.message;
      this.className = a.className;
      this.show = true;
      this.autoHide(a.time);
    });
  }
  hide() {
    this.show = false;
  }
  autoHide(time: number) {
    setTimeout(() => this.hide(), time);
  }
}
