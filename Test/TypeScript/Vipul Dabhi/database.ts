export interface restaurant{
    RestaurantId:number;
    Name:string;
    Location:string;
}
export interface rastaurantCapacity{
    DiningRoomId:number;
    Capacity:string;
}

export interface booked {
    RestaurantId:number;
    DiningRoomId:number;
    Date : Date;
}

export interface checkforBooking{
    DateOfBooking : Date;
    DiningId:number;
}

export var Restaurant : restaurant[];

Restaurant = [{RestaurantId:1,Name:"Taj-1",Location:"Gujarat"},
            {RestaurantId:2,Name:"Taj-2",Location:"Pune"},
            {RestaurantId:3,Name:"Taj-3",Location:"Mumbai"},
            {RestaurantId:4,Name:"Taj-4",Location:"UP"}]

export var Restaurant_1_Capacity : rastaurantCapacity[] = [{DiningRoomId:11,Capacity:"20-people"},
                                                    {DiningRoomId:12,Capacity:"15-people"},
                                                    {DiningRoomId:13,Capacity:"8-people"},]
                
export var Restaurant_2_Capacity : rastaurantCapacity[] = [{DiningRoomId:21,Capacity:"12-people"},
                                                    {DiningRoomId:22,Capacity:"5-people"},
                                                    {DiningRoomId:23,Capacity:"2-people"},]

export var Restaurant_3_Capacity : rastaurantCapacity[] = [{DiningRoomId:31,Capacity:"22-people"},
                                                    {DiningRoomId:32,Capacity:"7-people"},
                                                    {DiningRoomId:33,Capacity:"5-people"},]
                    
export var Restaurant_4_Capacity : rastaurantCapacity[] = [{DiningRoomId:41,Capacity:"23-people"},
                                                    {DiningRoomId:42,Capacity:"12-people"},
                                                    {DiningRoomId:43,Capacity:"3-people"},]

                                

export var BookedTable : booked[];

BookedTable = [];

export var checkTable : checkforBooking[];

checkTable = [];
