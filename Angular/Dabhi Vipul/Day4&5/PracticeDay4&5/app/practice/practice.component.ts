import { Component, OnInit } from '@angular/core';
import { FormGroup , FormControl, Validators } from '@angular/forms';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-practice',
  templateUrl: './practice.component.html',
  styleUrls: ['./practice.component.css']
})
export class PracticeComponent implements OnInit {

  myReactiveForm = new FormGroup({});

  // myReactiveForm = this.fb.group({
  //   firstname:['',Validators.required],      //validation 
  //   lastname:[''],
  //   address:this.fb.group({
  //     street:[''],
  //     city:[''],
  //     state:[''],
  //     zip:['']
  //   }),
  // });


  // constructor(private fb : FormBuilder) { }

  ngOnInit(): void {

    // this.myReactiveForm = new FormGroup({
    //   'userdetails' : new FormGroup({
    //     'username': new FormControl(null,Validators.required),
    //     'email' : new FormControl(null,[Validators.required,Validators.email])
    //   }),
    //   'course' : new FormControl('Angular')
    // });

    this.myReactiveForm = new FormGroup({
        'username': new FormControl(null,Validators.required),
        'email' : new FormControl(null,[Validators.required,Validators.email]),
        'course' : new FormControl('Angular')
    });

  }

  onSubmit(){
    console.log(this.myReactiveForm);
  }

  // update(){
  //     this.myReactiveForm.setValue({
  //       'username': 'Nancy',
  //       'email': 'nancy@gmail.com',
  //       'course' : 'HTML'
  //     });
  //   console.log(this.myReactiveForm);                         
  // }

  update(){
    this.myReactiveForm.patchValue({
      'username': 'Nancy',
      'email': 'nancy@gmail.com',
      'course' : 'HTML'
    });
  console.log(this.myReactiveForm);
                                
}

}
