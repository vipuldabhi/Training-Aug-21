import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'life-cycle-hooks';
  InputText:string="";
  ToggleComponent:boolean=true;

  toggel(){
    if(this.ToggleComponent){
      this.ToggleComponent = false;
    }else{
      this.ToggleComponent = true;
    }
  }
}
