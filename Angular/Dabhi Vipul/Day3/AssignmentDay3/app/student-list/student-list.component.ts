import { Component, OnInit } from '@angular/core';
import { Student } from '../student.model'; 

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

    students:Array<Student> = [{ID:1,Name:"Mehul",Age:22,Average:98,Grade:"A+",Active:true},
                                {ID:2,Name:"Jayesh",Age:21,Average:32,Grade:"F",Active:true},
                                {ID:3,Name:"Nitish",Age:23,Average:65,Grade:"C",Active:false},
                                {ID:4,Name:"Jhanvi",Age:25,Average:70,Grade:"B",Active:true},
                                {ID:5,Name:"Neha",Age:19,Average:80,Grade:"A",Active:false},]

  
  constructor() { }

  ngOnInit(): void {
  }

}
