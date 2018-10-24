import {Component} from '@angular/core';
import {Classe} from '../../models/Classe';
import {ClasseRepository} from '../classe.repository';

@Component({
  selector: 'app-listclase',
  templateUrl: 'list.classe.component.html'
})
export class ListClasseComponent {
  classes: Classe[] = [];
  constructor(private repository: ClasseRepository) {
    this.repository.List().subscribe(c => {
      this.classes = c ;
    });
    
  }
}
