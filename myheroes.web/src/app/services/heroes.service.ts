import { Injectable } from '@angular/core';

import { Hero } from '../models/hero.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { enviroments } from '../environments/environments';

@Injectable({
  providedIn: 'root'
})
export class HeroesService {
  private url = "Heroes" ;

  constructor(private httpClient : HttpClient) { }

  public getHeroes(): Observable<Hero[]> {

    return this.httpClient.get<Hero[]>(`${enviroments.apiUrl}/${this.url}`);
  }
}
