import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Params, Router } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private route : ActivatedRoute , private router : Router) { }

  user : any;

  navigateToAdmin(){
    // this.router.navigateByUrl('admin');
    this.router.navigate(['user','5','e ']); // using router
  }

  ngOnInit(): void {
    this.user = {
      id:this.route.snapshot.params['id'],
      name:this.route.snapshot.params['name']
    }
    // this.route.params.subscribe((data : Params)=>{
    //   this.user = {
    //     id : data['id'],
    //     name : data['name']
    //   }
    // });
    
    this.route.paramMap.subscribe((data : ParamMap)=>{
      this.user = {
        id : data.get('id'),
        name : data.get('name')
      }
    });
    
  }

}
