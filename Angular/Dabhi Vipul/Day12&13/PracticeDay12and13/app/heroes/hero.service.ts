import { Injectable } from '@angular/core';

import { map, Observable, of } from 'rxjs';

import { Hero } from './hero';
import { HEROES } from './mock.heroes'; 
import { MessageService } from '../message.service';

@Injectable({
  providedIn: 'root',
})
export class HeroService {

  constructor(private messageService: MessageService) { }

  getHeroes(): Observable<Hero[]> {
    const heroes = of(HEROES);
    this.messageService.add('HeroService: fetched heroes');
    return heroes;
  }

  getHero(id: any) {
    return this.getHeroes().pipe(
      map((heroes: Hero[]) => heroes.find(hero => hero.id == id)!)
    );
  }
}