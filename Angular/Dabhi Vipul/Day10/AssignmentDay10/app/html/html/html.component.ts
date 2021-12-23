import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-html',
  templateUrl: './html.component.html',
  styleUrls: ['./html.component.css']
})
export class HtmlComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {
  }
  navigateToDay1(){
    this.router.navigateByUrl('asignmentDay1');
  }
}
