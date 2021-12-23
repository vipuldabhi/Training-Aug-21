import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, FormsModule, MaxValidator, Validators } from '@angular/forms';

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {

  constructor(private fb : FormBuilder) { }

  ngOnInit(): void {
  }

  myForm = this.fb.group({
    name : ['',Validators.required],
    email : ['',[Validators.required,Validators.email]],
    languages : this.fb.array([
      this.getLanguage()
    ])
  });

  getLanguage():FormGroup{
    return this.fb.group({
      language : [''],
      des : ['']
    });
  }

  addLanguage(){
    (<FormArray>this.myForm.get('languages')).push(this.getLanguage());
  }

  removeLanguage() : void {
    (<FormArray>this.myForm.get('languages')).removeAt((this.getLanguage.length)-1);
  }

  onSubmit(){
    console.log(this.myForm);
  }

  get languages() {
    return this.myForm.get('languages') as FormArray;
  }

  get name() {
    return this.myForm.get('name');
  }

  get email() {
    return this.myForm.get('email');
  }

}
