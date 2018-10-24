import {Component} from '@angular/core';
import {Classe} from '../../models/Classe';
import {Periode} from '../../models/Periode';
import {Class} from '../classe';
import {Time} from '../../models/Time';
import {TimeTableRepository} from '../time-table.repository';


@Component({
  selector: 'app-classe',
  templateUrl: 'classe.component.html'
})
export class ClasseComponent {
  current: Classe;
  current2:Periode;
  timeTable = [];
  periodeTable= [];

  constructor(private classe: Class, private repository: TimeTableRepository) {
    this.classe.classe.subscribe(c => {
      console.log(this.current + "ffffff");
    });
   
    this.repository.list(this.current).subscribe(l => {
      this.timeTable = l;
    });

    this.repository.listPeriode(this.current2).subscribe(p => {
      this.periodeTable = p;
    });
  }
}
