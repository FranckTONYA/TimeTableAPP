import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Classe} from '../models/Classe';
import {Time} from '../models/Time';
import { Periode } from '../models/Periode';

@Injectable()
export class TimeTableRepository {
  url = 'http://localhost:5000/api/times';
  urlPeriode = 'http://localhost:5000/api/periodes';

  constructor(private httpClient: HttpClient) {}

  list(classe: Classe) {
    return  this.httpClient.get<Time[]>(this.url);
  }

  listPeriode(periode:Periode){
    return this.httpClient.get<Periode[]>(this.urlPeriode);
  }
}
