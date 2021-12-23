import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpcruddemoService {

  url : string;

  constructor(private http : HttpClient) { 
    this.url = "/api/customerdetails";
  }

  public getCustomers() : Observable<any>{
    let endPoints = "";
    return this.http.get<[]>(this.url+endPoints);
  }
          
  // public getCustomerById(id : number) : Observable<any>{
  //   let endPoints = "/"+id;
  //   return this.http.get(this.url+endPoints);
  // }

  public addCustomer(postData : any) {
    // let endPoints = "";
    // let headers = new Headers();
    // headers.append('Content-Type','application/json');

    this.http.post(this.url,postData).subscribe();
    // console.log("customer Added");
  }

  public updateCustomer(postData:object){
    let endPoints = "";
    this.http.put(this.url + endPoints, postData).subscribe();  
  }

  public deleteCustomer(id : number){
    let endPoints = "/delete/"+id;
    this.http.delete(this.url + endPoints).subscribe();
  }

}
