import {Subject} from 'rxjs';
import {Injectable} from '@angular/core';

export  class AlertDescriptor {
  constructor(
    public message: string,
    public className = 'bg-info',
    public time = 5000
  ) {}
}

@Injectable()
export class Alert {

  alert: Subject<AlertDescriptor> = new Subject();

  info(message: string, className = 'bg-info', time = 5000) {
    const descriptor = new AlertDescriptor(message, className, time);
    this.alert.next(descriptor);
  }
  error(message: string, time = 5000) {
    this.info(message, 'bg-danger', time);
  }
  success(message: string, time = 5000) {
    this.info(message, 'bg-success', time);
  }
}
