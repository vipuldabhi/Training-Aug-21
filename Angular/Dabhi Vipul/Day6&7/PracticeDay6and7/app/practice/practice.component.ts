import { Component, OnInit, ViewChild } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Hero } from '../hero';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent implements OnInit {

  // Dynamic Form

  constructor(private fb:FormBuilder) { }

  skillForm = this.fb.group({
    skill:this.fb.array([
      this.getSkill(),
    ])
  });

  getSkill():FormGroup {
    return this.fb.group({
      skill:[''],
      des:['']
    });
  }

  addSkill() : void {
    (<FormArray>this.skillForm.get('skill')).push(this.getSkill());
  }

  removeSkill() : void {
    (<FormArray>this.skillForm.get('skill')).removeAt((this.skill.length)-1);
  }

  get skill() {
    return this.skillForm.get('skill') as FormArray;
  }
  

  // Template Driven Form


  powers = ['Really Smart', 'Super Flexible',  
  'Super Hot', 'Weather Changer'];  

  model = new Hero(18, 'Dr IQ', this.powers[0], 'Chuck Overstreet');  

  submitted = false;  

  onSubmit() { this.submitted = true; }  

  // TODO: Remove this when we're done  

  get diagnostic() { return JSON.stringify(this.model); }  

  newHero() {
    this.model = new Hero(42, '', '');
  }

  ngOnInit(): void {
  }

}
