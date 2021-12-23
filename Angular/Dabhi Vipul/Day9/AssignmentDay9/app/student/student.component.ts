import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, Validators } from '@angular/forms';
import { StudentService } from '../service/student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css'],
})
export class StudentComponent implements OnInit {

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

  // StudentList :Array<any> = [];

  constructor(private fb : FormBuilder , private stu : StudentService) { }

  onSubmit(){
    this.stu.addStudent(this.studentForm.value);
    console.log(this.studentForm);
  }


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
