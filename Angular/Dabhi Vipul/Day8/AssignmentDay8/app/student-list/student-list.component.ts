import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

@Input() studentData:Array<any>=[];

  constructor() { }

  ngOnInit(): void {
  }

}
