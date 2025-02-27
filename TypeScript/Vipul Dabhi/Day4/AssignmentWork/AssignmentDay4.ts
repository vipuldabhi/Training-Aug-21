// Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.
interface empData{
    ID:number;
    Name:string;
    City:string;
    DOJ:Date;
}

var Employees : empData[] = [{ID:1,Name:"Mahesh",City:"Ahmedabad",DOJ:new Date(2020/2/12)},
                            {ID:2,Name:"Neha",City:"Surat",DOJ:new Date(2012/2/23)},
                            {ID:3,Name:"Sheetal",City:"Porbandar",DOJ:new Date(2021/2/23)},
                            {ID:4,Name:"Jayesh",City:"Rajkot",DOJ:new Date(2000/5/2)},
                            {ID:5,Name:"Neena",City:"Mumbai",DOJ:new Date("2022/1/12")}];
       
console.log("Enter Id Of employee");
var id : number = 1;
for(var x of Employees){
    
    if(x.ID === id){
        console.log(`\n Id : ${x.ID},Name : ${x.Name},City : ${x.City},DateOfJoining : ${x.DOJ}`);
    }
}

// Search the employees who has joined after year 2020

for(var i of Employees){ 
    
    if(i.DOJ.getFullYear() > 2020){
        console.log(`\n Id : ${i.ID},Name : ${i.Name},City : ${i.City},DateOfJoining : ${i.DOJ}`);
    }
}

// Search the employee who has joined after year 2020 and stays in Mumbai city

var FilterEmp = Employees.filter(i=>i.DOJ.getFullYear() > 2020 && i.City === "Mumbai");

for(var j of FilterEmp){
    console.log(`\n Id : ${j.ID},Name : ${j.Name},City : ${j.City},DateOfJoining : ${j.DOJ}`);
}

