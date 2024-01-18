import { Injectable } from '@angular/core';
import { Hero } from '../models/hero.model';

@Injectable({
  providedIn: 'root'
})
export class HeroesService {

  constructor() { }

  public getHeroes(): Hero[] {
    let hero: Hero = {
      id: 1,
      name: "Bruce Wayne",
      nameHero: "Batman",
      superpowers: ["Inteligencia","Artes Marciais","Super-Detetive"],
      weight: 85,
      height: 1.80,
      birthdate: new Date("2022-01-01T12:00:00")
    }

    return [hero];
  }
}
