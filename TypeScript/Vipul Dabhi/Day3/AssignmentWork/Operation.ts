interface ApplicantData{
    Id:number;
    Name : string;
    Gender : string;
    Age : number;
    Qualification : string; 
}
interface InterviewScheduleData{
    ApplicantId : number;
    ApplicantName : string;
    date : string;
    location : string;
    NameOfInterviewer : string;
}
interface InterviewResult{
    ApplicantId : number;
    ApplicantName : string;
    IsSelected : boolean;
}

interface HiredApplicant{
    ApplicantId:number;
    ApplicantName : string;
}

var ApplicantList : ApplicantData[];
var InterviewScheduleList : InterviewScheduleData[];
var interviewResult : InterviewResult[];
var HiredApplicant : HiredApplicant[];

    
class operation{


storeApplicantData(data) : void{
    
    ApplicantList.push(data);
    
    for(var i of ApplicantList){
        console.log(`Applicant Id is ${i.Id} name is ${i.Name} Gender is ${i.Gender} Qualification is ${i.Qualification} Age is ${i.Age}.`);
    }
    console.log("Applicant Data is Added");
}

scheduleInterview(data) : void{
    
    InterviewScheduleList.push(data);
    for(var i of InterviewScheduleList){
        console.log(`Applicant Id is ${i.ApplicantId} name is ${i.ApplicantName} NameOfInterviewer is ${i.NameOfInterviewer} Date of is ${i.date} Location is ${i.location}.`);
    }
    console.log("Interview is Scheduled for Listed Applicant");
}

interviewResult(data) : void{
    interviewResult.push(data);
}

hiringApplicant() : void{
    console.log("List of Appliant who Cleare Interview");

    for(var i of interviewResult){
        if(HiredApplicant.length <= 20){
            if(i.IsSelected === true){
                HiredApplicant.push(i);
            }
        }
        else{
            console.log("No Vacancies");
        }
    }

    console.log("This Employees Are Hired");

    for(var x of HiredApplicant){
      
        console.log(`${i.ApplicantName} is Hired`);
        
    }
    
}

report():void{
    console.log("This Employees Are Apply For Interview \n");
    for(var x of interviewResult){
        console.log(`${x.ApplicantName}\n`);
    }

    console.log("This Employees Are Hired \n");
    for(var y of HiredApplicant){
        console.log(`${y.ApplicantName}\n`);
    }
}

}

export {operation , ApplicantData,InterviewScheduleData,InterviewResult};