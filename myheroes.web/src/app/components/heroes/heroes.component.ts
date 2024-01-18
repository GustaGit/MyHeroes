import { Component, OnInit } from '@angular/core';
import { Hero } from 'src/app/models/hero.model';
import { HeroesService } from 'src/app/services/heroes.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  heroesList: Hero[] = [];
  heroesKeys: string[] = ['id','Nome','Nome Herói','Super-Poder','Data de Nascimento','Altura','Peso'];

  constructor(private heroesService: HeroesService) { }

  ngOnInit(): void {
    this.heroesList = this.heroesService.getHeroes();
  }
}
