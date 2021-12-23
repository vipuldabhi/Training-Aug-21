import { Injectable } from '@angular/core';
import { LoggerService } from './logger.service';

@Injectable({
  providedIn: 'root'
})
export class HeroService {         
  
  constructor(private logger : LoggerService) { }
   
  getHeroes() {
    return alert("Hello From Heroes");
  }
  getlogger(){
    this.logger.log();
  }
}
