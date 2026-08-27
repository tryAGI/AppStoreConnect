
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction
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
    public static class AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineBookTravel => "AIRLINE_BOOK_TRAVEL",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineCheckIn => "AIRLINE_CHECK_IN",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineFlightStatus => "AIRLINE_FLIGHT_STATUS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Apply => "APPLY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Book => "BOOK",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookActivities => "BOOK_ACTIVITIES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookRides => "BOOK_RIDES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookTeetimes => "BOOK_TEETIMES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookTours => "BOOK_TOURS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BuyTickets => "BUY_TICKETS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Careers => "CAREERS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ChargeEv => "CHARGE_EV",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Coupons => "COUPONS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Donate => "DONATE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Events => "EVENTS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.EventsShows => "EVENTS_SHOWS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.EventsSports => "EVENTS_SPORTS",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.GiftCard => "GIFT_CARD",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.HotelAmenities => "HOTEL_AMENITIES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.HotelBookRoom => "HOTEL_BOOK_ROOM",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Join => "JOIN",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ParkingAvailable => "PARKING_AVAILABLE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ParkingReserveParking => "PARKING_RESERVE_PARKING",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.PayToPark => "PAY_TO_PARK",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantJoinWaitlist => "RESTAURANT_JOIN_WAITLIST",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderDelivery => "RESTAURANT_ORDER_DELIVERY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderFood => "RESTAURANT_ORDER_FOOD",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderTakeout => "RESTAURANT_ORDER_TAKEOUT",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantPickup => "RESTAURANT_PICKUP",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantReservation => "RESTAURANT_RESERVATION",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantViewMenu => "RESTAURANT_VIEW_MENU",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailServiceQuote => "RETAIL_SERVICE_QUOTE",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStoreDelivery => "RETAIL_STORE_DELIVERY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStorePickup => "RETAIL_STORE_PICKUP",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStoreShop => "RETAIL_STORE_SHOP",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ScheduleAppointment => "SCHEDULE_APPOINTMENT",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Services => "SERVICES",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Support => "SUPPORT",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.TheaterNowPlaying => "THEATER_NOW_PLAYING",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ViewAvailability => "VIEW_AVAILABILITY",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ViewPricing => "VIEW_PRICING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction? ToEnum(string value)
        {
            return value switch
            {
                "AIRLINE_BOOK_TRAVEL" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineBookTravel,
                "AIRLINE_CHECK_IN" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineCheckIn,
                "AIRLINE_FLIGHT_STATUS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.AirlineFlightStatus,
                "APPLY" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Apply,
                "BOOK" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Book,
                "BOOK_ACTIVITIES" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookActivities,
                "BOOK_RIDES" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookRides,
                "BOOK_TEETIMES" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookTeetimes,
                "BOOK_TOURS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BookTours,
                "BUY_TICKETS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.BuyTickets,
                "CAREERS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Careers,
                "CHARGE_EV" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ChargeEv,
                "COUPONS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Coupons,
                "DONATE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Donate,
                "EVENTS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Events,
                "EVENTS_SHOWS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.EventsShows,
                "EVENTS_SPORTS" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.EventsSports,
                "GIFT_CARD" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.GiftCard,
                "HOTEL_AMENITIES" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.HotelAmenities,
                "HOTEL_BOOK_ROOM" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.HotelBookRoom,
                "JOIN" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Join,
                "PARKING_AVAILABLE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ParkingAvailable,
                "PARKING_RESERVE_PARKING" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ParkingReserveParking,
                "PAY_TO_PARK" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.PayToPark,
                "RESTAURANT_JOIN_WAITLIST" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantJoinWaitlist,
                "RESTAURANT_ORDER_DELIVERY" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderDelivery,
                "RESTAURANT_ORDER_FOOD" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderFood,
                "RESTAURANT_ORDER_TAKEOUT" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantOrderTakeout,
                "RESTAURANT_PICKUP" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantPickup,
                "RESTAURANT_RESERVATION" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantReservation,
                "RESTAURANT_VIEW_MENU" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RestaurantViewMenu,
                "RETAIL_SERVICE_QUOTE" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailServiceQuote,
                "RETAIL_STORE_DELIVERY" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStoreDelivery,
                "RETAIL_STORE_PICKUP" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStorePickup,
                "RETAIL_STORE_SHOP" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.RetailStoreShop,
                "SCHEDULE_APPOINTMENT" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ScheduleAppointment,
                "SERVICES" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Services,
                "SUPPORT" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.Support,
                "THEATER_NOW_PLAYING" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.TheaterNowPlaying,
                "VIEW_AVAILABILITY" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ViewAvailability,
                "VIEW_PRICING" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceMapAction.ViewPricing,
                _ => null,
            };
        }
    }
}