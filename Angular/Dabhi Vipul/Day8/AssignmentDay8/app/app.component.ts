import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AssignmentDay8';

  student : any = [];

  stData :Array<any>=[{firstname:"vipul",middlename:"Bharatbhai",lastname:"Dabhi",dateofbirth:"15-2-2000",
                placeofbirth:"surendranagar",firstlanguage:"Hindi",fatherfirstname:"dabhi",motherfirstname:"Dabhi"}]

  getData(data : any){
    console.log(data);
    this.student = data;
  }

}
