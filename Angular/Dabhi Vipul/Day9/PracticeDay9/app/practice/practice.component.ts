import { Component, OnInit } from '@angular/core';
import { HeroService } from '../heroes/hero.service';


@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent implements OnInit {

  constructor(private _heroService:HeroService) { }

  

  ngOnInit(): void {
  }

onClick(){
  this._heroService.getHeroes();
  
}
onClick2(){
  this._heroService.getlogger();
}

}
