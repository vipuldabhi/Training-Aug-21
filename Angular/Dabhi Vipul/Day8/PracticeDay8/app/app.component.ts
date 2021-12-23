import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  name:string="";
  value="";
  dataFunction(data : any){
    console.log(data);
    this.value=data.name;
  }

}
