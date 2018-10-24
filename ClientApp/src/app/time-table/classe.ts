import {Subject} from 'rxjs';
import {Injectable} from '@angular/core';
import {Classe} from '../models/Classe';

export class ClasseDescriptior {
  constructor(
    public Idfiliere?: number,
    public Codgrade?: string,
    public Niveau?: string,
    public Idspecialite?: number
  ) {}
}

@Injectable()
export class Class {
  classe: Subject<Classe> = new Subject();
  selectClasse (classe: Classe) {
    const descriptor = classe;
    this.classe.next(descriptor);
  }
}
