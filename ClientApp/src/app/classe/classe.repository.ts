import {HttpClient} from '@angular/common/http';
import {Classe} from '../models/Classe';
import {Injectable} from '@angular/core';
import { from } from 'rxjs';

@Injectable()
export class ClasseRepository {
  private url = 'http://localhost:5000/api/classes';

  constructor(private httpClient: HttpClient) {

  }

 

  List() {
    return this.httpClient.get<Classe[]>(this.url);
  }
  findById(id: number) {
    return this.httpClient.get<Classe>(`${this.url}/${id}`);
  }
}
