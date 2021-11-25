// This project is aimed at developing a web-based and central Recruitment Process System 
// for the HR Group for a company. Some features of this system will be creating vacancies, 
// storing Applicants data, Interview process initiation, Scheduling Interviews, 
// Storing Interview results for the applicant and finally Hiring of the applicant. 
// Reports may be required to be generated for the use of HR group.

import {operation , ApplicantData,InterviewScheduleData,InterviewResult} from "./Operation";

var oprObj = new operation();


var PHPTotalVacancies : number = 0;
var DOTNETTotalVacancies : number = 0;
var NodeTotalVacancies : number = 0;

console.log("Enter 1 for Create Vacancies");
console.log("Enter 2 for Store Applicants Data");
console.log("Enter 3 for Scheduling Interviews");
console.log("Enter 4 for Storing Interview results");
console.log("Enter 5 for Hiring of the applicant");
console.log("Enter 6 for Generet Report For Hr Group");

var value : number = 1;

switch(value){
    
    case 1:
        console.log("enter PHP for php Vacancies");
        console.log("enter .NET for DOTNET Vacancies");
        console.log("enter Node for Node Vacancies");

        var forVacancies : string = "PHP";

        if(forVacancies === "PHP"){
            console.log("Enter No Of vacancies You Want to Create For PHP.");
            var PHPVacancies : number = 20;
            PHPTotalVacancies = PHPTotalVacancies + PHPVacancies;
            console.log(`${PHPVacancies}Vacancies Created For PHP`);
        }
        else if(forVacancies === "DOTNET"){
            console.log("Enter No Of vacancies You Want to Create For .NET.");
            var DOTNETVacancies : number = 20;
            DOTNETTotalVacancies = DOTNETTotalVacancies + DOTNETVacancies;
            console.log("Vacancies Created For DOTNET");
        }
        else if(forVacancies === "Node"){
            console.log("Enter No Of vacancies You Want to Create For Node.");
            var NodeVacancies : number = 20;
            NodeTotalVacancies = NodeTotalVacancies + NodeVacancies;
            console.log("Vacancies Created For Node");
        }
        break;
    case 2:
        console.log("Enter Applicant Data \n");
        console.log("Enter Applicant Id,Name,Gender,Age,Qualification");

        var id = 1;
        var name = "Mahesh";
        var gender = "Male";
        var qualification = "engineering";
        var age = 23;

        var ApplData : ApplicantData[]

        ApplData = [{Id:id,Name:name,Gender:gender,Qualification:qualification,Age:age}];

        oprObj.storeApplicantData(ApplData);

        break;
    case 3:
        var interview :InterviewScheduleData[];

        interview = [{ApplicantId:1,ApplicantName:"Mahesh", date:"12/1/2020",location:"Charodi,Ahmedabad",NameOfInterviewer:"JitenSir"}];

        oprObj.scheduleInterview(interview);

        break;
    case 4:
        var result : InterviewResult[];

        result = [{ApplicantId:1,ApplicantName:"Mahesh", IsSelected:true}];
        
        oprObj.interviewResult(result);
        break;
    case 5:
        oprObj.hiringApplicant();
        break;
    case 6:
        oprObj.report();
        break;
    default:
        console.log("Invalid Choice");
        break;
}