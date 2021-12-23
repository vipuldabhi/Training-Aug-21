import { Injectable } from '@angular/core';
import { Student } from '../student';
import { StudentComponent } from '../student/student.component';
import { StudentlistComponent } from '../studentlist/studentlist.component';
import { LogService } from './log.service';

@Injectable({
  providedIn: 'root'
})
export class StudentService  {

  constructor(private log : LogService) { }
  
  studentList : Student[] = [];

  addStudent(data : any){
    this.studentList.push(data);
    this.log.logInsert();
  }

  getStudent(){
    this.log.logRead();
    return this.studentList;
  }

  deleteStudent(index : number){
    this.studentList.splice(index,1);
    this.log.logDelete();
  }

  updateStudent(){
    this.log.logUpdate();
  }
}
