import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private auth : AuthService) { }

  ngOnInit(): void {
  }

  user : string = "";
  password : string = "";
  flag : string = "";

  login(){
    this.auth.login(this.user,this.password);
    if(this.auth.login(this.user,this.password)){
      this.flag = "sucessfully Loged In !!!";
    }else{
      this.flag = "Please Enter Valid User Or Password !!!";
    }
  }

  logOut(){
    this.auth.logout();
    this.flag = "sucessfully Loged Out !!!";

  }

  checkForLogOut(){
    if(localStorage.getItem('username')){
      return true;
    }else{
      return false;
    }
  }

  checkForLogin(){
    if(localStorage.getItem('username')){
      return false;
    }else{
      return true;
    }
  }

}
