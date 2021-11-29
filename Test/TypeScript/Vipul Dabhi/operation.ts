import * as data from "./database";


export function listOfRestaurant() : void{
    var list = data.Restaurant;

    for(var i of list){
        console.log(`RestaurantId : ${i.RestaurantId} Name : ${i.Name} Location : ${i.Location}`);
    }

    console.log("Enter Restaurant Id In which You Want to view Table Details");
    var ResId : number = 1;

    if(ResId === 1){
        for(var x of data.Restaurant_1_Capacity){
            console.log(`DiningRoomId : ${x.DiningRoomId} Capacity Of People : ${x.Capacity}`);
        }
    }
    else if(ResId === 2){
        for(var y of data.Restaurant_2_Capacity){
            console.log(`DiningRoomId : ${y.DiningRoomId} Capacity Of People : ${y.Capacity}`);
        }
    }
    else if(ResId === 3){
        for(var z of data.Restaurant_3_Capacity){
            console.log(`DiningRoomId : ${z.DiningRoomId} Capacity Of People : ${z.Capacity}`);
        }
    }
    else if(ResId === 4){
        for(var j of data.Restaurant_4_Capacity){
            console.log(`DiningRoomId : ${j.DiningRoomId} Capacity Of People : ${j.Capacity}`);
        }
    }
    
}


export function BookingOfTable() : void{

    console.log("Enter RestaurantId , DiningRoom ID And Date");

    var restaurantId : number = 2;
    var dininggRoomId : number = 21;
    let date: Date = new Date("2021-11-29"); 
    
    var checkValue = checkForAvailability(date,dininggRoomId)

    var bookingData = {RestaurantId:restaurantId,
                        DiningRoomId:dininggRoomId,
                        Date : date}
    var checkData = {DateOfBooking : date,
                        DiningId:dininggRoomId}

    if(checkValue === "Available"){

        data.BookedTable.push(bookingData);
        data.checkTable.push(checkData);

        var token : number = restaurantId + dininggRoomId;

        console.log(`Your Token For Booked Table Is ${token}`);

    }
    else if(checkValue === "Late"){

        console.log("You Are Too Late For Booking")
    }
    else if(checkValue === "Early"){

        console.log("You Are Too Early For Booking")

    }
    
}


export function viewBookingData() : void 
{
    console.log("List Of Booked Table");
    for(var k of data.BookedTable){
        console.log(`RestaurantId : ${k.RestaurantId} DiningRoomId : ${k.DiningRoomId} Date Of Booking : ${k.Date}`);
    }
}


function checkForAvailability(date : any , id : number) : string {

    var currentDate :any = new Date();

    var hours = Math.abs(currentDate - date ) / 36e5;

    if(hours < 6 && !date < currentDate){
        return ("Late");
    }
    else if(hours > 720 && !date < currentDate){
        return ("Early");
    }
    else if(hours > 6 && hours < 720 && !date < currentDate)
    {
        return ("Available");
    }
    else{
        console.log("Invalid Choice");
    }

}