import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class LoggedinguardService {

  constructor(private authService : AuthService , private router : Router) { }

  canActivate():boolean{

    // return this.authService.isLoggedIn();
    if(this.authService.isLoggedIn()){
      return true;
    }else{
      this.router.navigate(['login']);
      return false;
    }
  }

}
