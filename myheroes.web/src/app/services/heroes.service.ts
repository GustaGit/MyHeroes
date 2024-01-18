import { Injectable } from '@angular/core';
import { Hero } from '../models/hero.model';

@Injectable({
  providedIn: 'root'
})
export class HeroesService {

  constructor() { }

  public getHeroes() : Hero[] {
    let hero:Hero;
    hero.id = 1;
    hero.name = "Bruce Wayne";
    hero.nameHero = "Batman";
    hero.superpower = "Nenhum";
    hero.weight = 85;
    hero.height = 1.80
    hero.birthdate= new Date("2022-01-01T12:00:00");

    return [hero];
  }
}
