import { Component, OnInit } from '@angular/core';
import { StudentService } from '../service/student.service';
import { Student } from '../student';

@Component({
  selector: 'app-studentlist',
  templateUrl: './studentlist.component.html',
  styleUrls: ['./studentlist.component.css']
})
export class StudentlistComponent implements OnInit {

  constructor(private student : StudentService) { }

  ngOnInit(): void {
  }

  studentData : Student[] = [];

  id : number = 0;
  idUpdate : number = 0;

  displayStudent(){
    this.studentData = this.student.getStudent();
  }

  deleteStudent(){
    this.student.deleteStudent(this.id);
  }

  updateStudent(){
    this.student.updateStudent();
  }

}
