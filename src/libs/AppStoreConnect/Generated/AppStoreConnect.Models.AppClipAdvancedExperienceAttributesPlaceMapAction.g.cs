
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesPlaceMapAction
    {
        /// <summary>
        ///
        /// </summary>
        AirlineBookTravel,
        /// <summary>
        ///
        /// </summary>
        AirlineCheckIn,
        /// <summary>
        ///
        /// </summary>
        AirlineFlightStatus,
        /// <summary>
        ///
        /// </summary>
        Apply,
        /// <summary>
        ///
        /// </summary>
        Book,
        /// <summary>
        ///
        /// </summary>
        BookActivities,
        /// <summary>
        ///
        /// </summary>
        BookRides,
        /// <summary>
        ///
        /// </summary>
        BookTeetimes,
        /// <summary>
        ///
        /// </summary>
        BookTours,
        /// <summary>
        ///
        /// </summary>
        BuyTickets,
        /// <summary>
        ///
        /// </summary>
        Careers,
        /// <summary>
        ///
        /// </summary>
        ChargeEv,
        /// <summary>
        ///
        /// </summary>
        Coupons,
        /// <summary>
        ///
        /// </summary>
        Donate,
        /// <summary>
        ///
        /// </summary>
        Events,
        /// <summary>
        ///
        /// </summary>
        EventsShows,
        /// <summary>
        ///
        /// </summary>
        EventsSports,
        /// <summary>
        ///
        /// </summary>
        GiftCard,
        /// <summary>
        ///
        /// </summary>
        HotelAmenities,
        /// <summary>
        ///
        /// </summary>
        HotelBookRoom,
        /// <summary>
        ///
        /// </summary>
        Join,
        /// <summary>
        ///
        /// </summary>
        ParkingAvailable,
        /// <summary>
        ///
        /// </summary>
        ParkingReserveParking,
        /// <summary>
        ///
        /// </summary>
        PayToPark,
        /// <summary>
        ///
        /// </summary>
        RestaurantJoinWaitlist,
        /// <summary>
        ///
        /// </summary>
        RestaurantOrderDelivery,
        /// <summary>
        ///
        /// </summary>
        RestaurantOrderFood,
        /// <summary>
        ///
        /// </summary>
        RestaurantOrderTakeout,
        /// <summary>
        ///
        /// </summary>
        RestaurantPickup,
        /// <summary>
        ///
        /// </summary>
        RestaurantReservation,
        /// <summary>
        ///
        /// </summary>
        RestaurantViewMenu,
        /// <summary>
        ///
        /// </summary>
        RetailServiceQuote,
        /// <summary>
        ///
        /// </summary>
        RetailStoreDelivery,
        /// <summary>
        ///
        /// </summary>
        RetailStorePickup,
        /// <summary>
        ///
        /// </summary>
        RetailStoreShop,
        /// <summary>
        ///
        /// </summary>
        ScheduleAppointment,
        /// <summary>
        ///
        /// </summary>
        Services,
        /// <summary>
        ///
        /// </summary>
        Support,
        /// <summary>
        ///
        /// </summary>
        TheaterNowPlaying,
        /// <summary>
        ///
        /// </summary>
        ViewAvailability,
        /// <summary>
        ///
        /// </summary>
        ViewPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceAttributesPlaceMapActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesPlaceMapAction value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineBookTravel => "AIRLINE_BOOK_TRAVEL",
                AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineCheckIn => "AIRLINE_CHECK_IN",
                AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineFlightStatus => "AIRLINE_FLIGHT_STATUS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Apply => "APPLY",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Book => "BOOK",
                AppClipAdvancedExperienceAttributesPlaceMapAction.BookActivities => "BOOK_ACTIVITIES",
                AppClipAdvancedExperienceAttributesPlaceMapAction.BookRides => "BOOK_RIDES",
                AppClipAdvancedExperienceAttributesPlaceMapAction.BookTeetimes => "BOOK_TEETIMES",
                AppClipAdvancedExperienceAttributesPlaceMapAction.BookTours => "BOOK_TOURS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.BuyTickets => "BUY_TICKETS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Careers => "CAREERS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ChargeEv => "CHARGE_EV",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Coupons => "COUPONS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Donate => "DONATE",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Events => "EVENTS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.EventsShows => "EVENTS_SHOWS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.EventsSports => "EVENTS_SPORTS",
                AppClipAdvancedExperienceAttributesPlaceMapAction.GiftCard => "GIFT_CARD",
                AppClipAdvancedExperienceAttributesPlaceMapAction.HotelAmenities => "HOTEL_AMENITIES",
                AppClipAdvancedExperienceAttributesPlaceMapAction.HotelBookRoom => "HOTEL_BOOK_ROOM",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Join => "JOIN",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ParkingAvailable => "PARKING_AVAILABLE",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ParkingReserveParking => "PARKING_RESERVE_PARKING",
                AppClipAdvancedExperienceAttributesPlaceMapAction.PayToPark => "PAY_TO_PARK",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantJoinWaitlist => "RESTAURANT_JOIN_WAITLIST",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderDelivery => "RESTAURANT_ORDER_DELIVERY",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderFood => "RESTAURANT_ORDER_FOOD",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderTakeout => "RESTAURANT_ORDER_TAKEOUT",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantPickup => "RESTAURANT_PICKUP",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantReservation => "RESTAURANT_RESERVATION",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantViewMenu => "RESTAURANT_VIEW_MENU",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RetailServiceQuote => "RETAIL_SERVICE_QUOTE",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStoreDelivery => "RETAIL_STORE_DELIVERY",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStorePickup => "RETAIL_STORE_PICKUP",
                AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStoreShop => "RETAIL_STORE_SHOP",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ScheduleAppointment => "SCHEDULE_APPOINTMENT",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Services => "SERVICES",
                AppClipAdvancedExperienceAttributesPlaceMapAction.Support => "SUPPORT",
                AppClipAdvancedExperienceAttributesPlaceMapAction.TheaterNowPlaying => "THEATER_NOW_PLAYING",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ViewAvailability => "VIEW_AVAILABILITY",
                AppClipAdvancedExperienceAttributesPlaceMapAction.ViewPricing => "VIEW_PRICING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesPlaceMapAction? ToEnum(string value)
        {
            return value switch
            {
                "AIRLINE_BOOK_TRAVEL" => AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineBookTravel,
                "AIRLINE_CHECK_IN" => AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineCheckIn,
                "AIRLINE_FLIGHT_STATUS" => AppClipAdvancedExperienceAttributesPlaceMapAction.AirlineFlightStatus,
                "APPLY" => AppClipAdvancedExperienceAttributesPlaceMapAction.Apply,
                "BOOK" => AppClipAdvancedExperienceAttributesPlaceMapAction.Book,
                "BOOK_ACTIVITIES" => AppClipAdvancedExperienceAttributesPlaceMapAction.BookActivities,
                "BOOK_RIDES" => AppClipAdvancedExperienceAttributesPlaceMapAction.BookRides,
                "BOOK_TEETIMES" => AppClipAdvancedExperienceAttributesPlaceMapAction.BookTeetimes,
                "BOOK_TOURS" => AppClipAdvancedExperienceAttributesPlaceMapAction.BookTours,
                "BUY_TICKETS" => AppClipAdvancedExperienceAttributesPlaceMapAction.BuyTickets,
                "CAREERS" => AppClipAdvancedExperienceAttributesPlaceMapAction.Careers,
                "CHARGE_EV" => AppClipAdvancedExperienceAttributesPlaceMapAction.ChargeEv,
                "COUPONS" => AppClipAdvancedExperienceAttributesPlaceMapAction.Coupons,
                "DONATE" => AppClipAdvancedExperienceAttributesPlaceMapAction.Donate,
                "EVENTS" => AppClipAdvancedExperienceAttributesPlaceMapAction.Events,
                "EVENTS_SHOWS" => AppClipAdvancedExperienceAttributesPlaceMapAction.EventsShows,
                "EVENTS_SPORTS" => AppClipAdvancedExperienceAttributesPlaceMapAction.EventsSports,
                "GIFT_CARD" => AppClipAdvancedExperienceAttributesPlaceMapAction.GiftCard,
                "HOTEL_AMENITIES" => AppClipAdvancedExperienceAttributesPlaceMapAction.HotelAmenities,
                "HOTEL_BOOK_ROOM" => AppClipAdvancedExperienceAttributesPlaceMapAction.HotelBookRoom,
                "JOIN" => AppClipAdvancedExperienceAttributesPlaceMapAction.Join,
                "PARKING_AVAILABLE" => AppClipAdvancedExperienceAttributesPlaceMapAction.ParkingAvailable,
                "PARKING_RESERVE_PARKING" => AppClipAdvancedExperienceAttributesPlaceMapAction.ParkingReserveParking,
                "PAY_TO_PARK" => AppClipAdvancedExperienceAttributesPlaceMapAction.PayToPark,
                "RESTAURANT_JOIN_WAITLIST" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantJoinWaitlist,
                "RESTAURANT_ORDER_DELIVERY" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderDelivery,
                "RESTAURANT_ORDER_FOOD" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderFood,
                "RESTAURANT_ORDER_TAKEOUT" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantOrderTakeout,
                "RESTAURANT_PICKUP" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantPickup,
                "RESTAURANT_RESERVATION" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantReservation,
                "RESTAURANT_VIEW_MENU" => AppClipAdvancedExperienceAttributesPlaceMapAction.RestaurantViewMenu,
                "RETAIL_SERVICE_QUOTE" => AppClipAdvancedExperienceAttributesPlaceMapAction.RetailServiceQuote,
                "RETAIL_STORE_DELIVERY" => AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStoreDelivery,
                "RETAIL_STORE_PICKUP" => AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStorePickup,
                "RETAIL_STORE_SHOP" => AppClipAdvancedExperienceAttributesPlaceMapAction.RetailStoreShop,
                "SCHEDULE_APPOINTMENT" => AppClipAdvancedExperienceAttributesPlaceMapAction.ScheduleAppointment,
                "SERVICES" => AppClipAdvancedExperienceAttributesPlaceMapAction.Services,
                "SUPPORT" => AppClipAdvancedExperienceAttributesPlaceMapAction.Support,
                "THEATER_NOW_PLAYING" => AppClipAdvancedExperienceAttributesPlaceMapAction.TheaterNowPlaying,
                "VIEW_AVAILABILITY" => AppClipAdvancedExperienceAttributesPlaceMapAction.ViewAvailability,
                "VIEW_PRICING" => AppClipAdvancedExperienceAttributesPlaceMapAction.ViewPricing,
                _ => null,
            };
        }
    }
}