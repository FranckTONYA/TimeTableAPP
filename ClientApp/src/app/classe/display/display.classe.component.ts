import {Component} from '@angular/core';
import {ClasseRepository} from '../classe.repository';
import {ActivatedRoute, Router} from '@angular/router';
import {Classe} from '../../models/Classe';
import {Class} from '../../time-table/classe';

@Component({
  templateUrl: 'display.classe.component.html'
})
export class DisplayClasseComponent {
  classe: Classe;
  constructor(private repository: ClasseRepository, private route: ActivatedRoute, private time: Class, private router: Router) {
    const id = this.route.snapshot.params['id'];
    this.repository.findById(id).subscribe(c => {
      this.classe = c;
      this.time.selectClasse(this.classe);
      this.router.navigate(['times', id, 'display']);
    });
  }
}
