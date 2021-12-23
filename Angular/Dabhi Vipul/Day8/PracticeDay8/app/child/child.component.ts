import { Component, Input, OnInit ,Output ,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  @Input() UserName:string="";           

  @Output() dataFunction:EventEmitter<any> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
    
  }

  sendData(){
    var Name = {name:"nayan",age:23};
    this.dataFunction.emit(Name);
  }



}
