import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username : string = "";
  password : string = "";

  ValidateUsername : string = "admin";
  ValidatePassword : string = "admin";

  validation : string = "";

  UserLogin(username:string,password:string){
    if(username === this.ValidateUsername && password === this.ValidatePassword){
      this.validation = "You Are Valid User";
    }
    else{
      this.validation = "You Are Not a Valid User";
    }
  }

  constructor() { }

  ngOnInit(): void {
  }

}
