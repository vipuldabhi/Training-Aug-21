import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { FormBuilder, FormArray } from '@angular/forms';
import { Student } from '../student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
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
      fatherfirstname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      fathermiddlename : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      fatherlastname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      fatheremail : ['',Validators.email],
      fatherqualification : [''],
      fatherprofession : [''],
      fatherdesignation : [''],
      fatherphone : ['',Validators.pattern('[1-9][0-9]{9,9}')]
    }),
    mother : this.fb.group({
      motherfirstname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      mothermiddlename : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      motherlastname : ['',[Validators.required,Validators.pattern('[a-zA-Z]*')]],
      motheremail : ['',Validators.email],
      motherqualification : [''],
      motherprofession : [''],
      motherdesignation : [''],
      motherphone : ['',Validators.pattern('[1-9][0-9]{9,9}')]
    }),
    emergency : this.fb.array([
        this.fb.group({
        relation : ['',Validators.required],
        emergencyphone : ['',Validators.required]
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

}
