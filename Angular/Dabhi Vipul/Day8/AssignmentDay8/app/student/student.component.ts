import { Component, OnInit, Output ,EventEmitter} from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { FormBuilder, FormArray } from '@angular/forms';
import { Student } from '../student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  @Output() sendData:EventEmitter<any> = new EventEmitter();

  sendFromHere(){
    this.sendData.emit(this.StudentList);
  }

  studentForm = this.fb.group({
    firstname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
    middlename : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
    lastname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
    dateofbirth : ['',Validators.required],
    placeofbirth : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
    firstlanguage : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
    address : this.fb.group({
      city : [''],
      state : [''],
      country : [''],
      pin : ['',Validators.minLength(6)]
    }),
    father : this.fb.group({
      firstname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      middlename : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      lastname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      email : ['',Validators.email],
      qualification : [''],
      profession : [''],
      designation : [''],
      phone : ['']
    }),
    mother : this.fb.group({
      firstname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      middlename : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      lastname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      email : ['',Validators.email],
      qualification : [''],
      profession : [''],
      designation : [''],
      phone : ['']
    }),
    emergency : this.fb.array([
        this.fb.group({
        relation : ['',Validators.required],
        phone : ['',Validators.required]
      })
    ]),
    reference : this.fb.group({
      refdetails : [''],
      refthrough : [''],
      refaddress : ['']
    }),

  });

  StudentList : Student[] = [];

  onSubmit(){
    this.StudentList.push(this.studentForm.value);
    console.log(this.studentForm);
  }

  constructor(private fb : FormBuilder) { }

  ngOnInit(): void {
  }


  get emergency() {
    return this.studentForm.get('emergency') as FormArray;
  }

  get firstname() {
    return this.studentForm.get('firstname');
  }

  get middlename() {
    return this.studentForm.get('middlename');
  }

  get lastname() {
    return this.studentForm.get('lastname');
  }

  get placeofbirth() {
    return this.studentForm.get('placeofbirth');
  }

  get firstlanguage() {
    return this.studentForm.get('firstlanguage');
  }

  get email() {
    return this.studentForm.get('email');
  }


}
