import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LogService {

  constructor() { }

  logInsert(){
    console.log("Insert Operation Perform");
  }

  logDelete(){
    console.log("Delete Operation Perform");
  }

  logRead(){
    console.log("Read Operation Perform");
  }

  logUpdate(){
    console.log("Update Operation Perform");
  }

}
