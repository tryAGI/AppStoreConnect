
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction
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
    public static class AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineBookTravel => "AIRLINE_BOOK_TRAVEL",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineCheckIn => "AIRLINE_CHECK_IN",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineFlightStatus => "AIRLINE_FLIGHT_STATUS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Apply => "APPLY",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Book => "BOOK",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookActivities => "BOOK_ACTIVITIES",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookRides => "BOOK_RIDES",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookTeetimes => "BOOK_TEETIMES",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookTours => "BOOK_TOURS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BuyTickets => "BUY_TICKETS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Careers => "CAREERS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ChargeEv => "CHARGE_EV",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Coupons => "COUPONS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Donate => "DONATE",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Events => "EVENTS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.EventsShows => "EVENTS_SHOWS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.EventsSports => "EVENTS_SPORTS",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.GiftCard => "GIFT_CARD",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.HotelAmenities => "HOTEL_AMENITIES",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.HotelBookRoom => "HOTEL_BOOK_ROOM",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Join => "JOIN",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ParkingAvailable => "PARKING_AVAILABLE",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ParkingReserveParking => "PARKING_RESERVE_PARKING",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.PayToPark => "PAY_TO_PARK",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantJoinWaitlist => "RESTAURANT_JOIN_WAITLIST",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderDelivery => "RESTAURANT_ORDER_DELIVERY",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderFood => "RESTAURANT_ORDER_FOOD",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderTakeout => "RESTAURANT_ORDER_TAKEOUT",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantPickup => "RESTAURANT_PICKUP",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantReservation => "RESTAURANT_RESERVATION",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantViewMenu => "RESTAURANT_VIEW_MENU",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailServiceQuote => "RETAIL_SERVICE_QUOTE",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStoreDelivery => "RETAIL_STORE_DELIVERY",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStorePickup => "RETAIL_STORE_PICKUP",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStoreShop => "RETAIL_STORE_SHOP",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ScheduleAppointment => "SCHEDULE_APPOINTMENT",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Services => "SERVICES",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Support => "SUPPORT",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.TheaterNowPlaying => "THEATER_NOW_PLAYING",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ViewAvailability => "VIEW_AVAILABILITY",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ViewPricing => "VIEW_PRICING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction? ToEnum(string value)
        {
            return value switch
            {
                "AIRLINE_BOOK_TRAVEL" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineBookTravel,
                "AIRLINE_CHECK_IN" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineCheckIn,
                "AIRLINE_FLIGHT_STATUS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.AirlineFlightStatus,
                "APPLY" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Apply,
                "BOOK" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Book,
                "BOOK_ACTIVITIES" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookActivities,
                "BOOK_RIDES" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookRides,
                "BOOK_TEETIMES" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookTeetimes,
                "BOOK_TOURS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BookTours,
                "BUY_TICKETS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.BuyTickets,
                "CAREERS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Careers,
                "CHARGE_EV" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ChargeEv,
                "COUPONS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Coupons,
                "DONATE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Donate,
                "EVENTS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Events,
                "EVENTS_SHOWS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.EventsShows,
                "EVENTS_SPORTS" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.EventsSports,
                "GIFT_CARD" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.GiftCard,
                "HOTEL_AMENITIES" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.HotelAmenities,
                "HOTEL_BOOK_ROOM" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.HotelBookRoom,
                "JOIN" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Join,
                "PARKING_AVAILABLE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ParkingAvailable,
                "PARKING_RESERVE_PARKING" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ParkingReserveParking,
                "PAY_TO_PARK" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.PayToPark,
                "RESTAURANT_JOIN_WAITLIST" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantJoinWaitlist,
                "RESTAURANT_ORDER_DELIVERY" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderDelivery,
                "RESTAURANT_ORDER_FOOD" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderFood,
                "RESTAURANT_ORDER_TAKEOUT" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantOrderTakeout,
                "RESTAURANT_PICKUP" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantPickup,
                "RESTAURANT_RESERVATION" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantReservation,
                "RESTAURANT_VIEW_MENU" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RestaurantViewMenu,
                "RETAIL_SERVICE_QUOTE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailServiceQuote,
                "RETAIL_STORE_DELIVERY" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStoreDelivery,
                "RETAIL_STORE_PICKUP" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStorePickup,
                "RETAIL_STORE_SHOP" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.RetailStoreShop,
                "SCHEDULE_APPOINTMENT" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ScheduleAppointment,
                "SERVICES" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Services,
                "SUPPORT" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.Support,
                "THEATER_NOW_PLAYING" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.TheaterNowPlaying,
                "VIEW_AVAILABILITY" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ViewAvailability,
                "VIEW_PRICING" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceMapAction.ViewPricing,
                _ => null,
            };
        }
    }
}