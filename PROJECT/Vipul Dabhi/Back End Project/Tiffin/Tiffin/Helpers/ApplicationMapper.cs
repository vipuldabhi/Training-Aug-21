using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()     
        {
            CreateMap<Area, AreaDto>().ReverseMap();
            CreateMap<WeekDay, WeekDayDto>().ReverseMap();
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<FoodType, FoodTypeDto>().ReverseMap();
            CreateMap<Duration, DurationDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            CreateMap<ContactInfo, ContactInfoDto>().ReverseMap();
            CreateMap<DeliveryStatus, DeliveryStatusDto>().ReverseMap();
            CreateMap<CancellationStatus, CancellationStatusDto>().ReverseMap();
            CreateMap<DayWiseMenu, DayWiseMenuDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantsDto>().ReverseMap();
            CreateMap<MealCharge, MealChargesDto>().ReverseMap();
            CreateMap<Interval, IntervalDto>().ReverseMap();
            CreateMap<Rating, RatingDto>().ReverseMap();
            CreateMap<AvgRating, AvgRatingDto>().ReverseMap();
            CreateMap<DeliveryBoy, DeliveryBoyDto>().ReverseMap();
            CreateMap<DeliveryCharge, DeliveryChargesDto>().ReverseMap();


        }
    }
}
