﻿using EventsAPI.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Data
{
    public static class EventsSeed
    {
        public static void Seed(EventsContext eventsContext)
        {
            eventsContext.Database.Migrate();

            if(!eventsContext.EventHosts.Any())
            {
                eventsContext.EventHosts.AddRange(GetEventsHosts());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.EventTypes.Any())
            {
                eventsContext.EventTypes.AddRange(GetEventsType());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.Locations.Any())
            {
                eventsContext.Locations.AddRange(GetEventsLocations());
                eventsContext.SaveChanges();
            }
            if (!eventsContext.Events.Any())
            {
                eventsContext.Events.AddRange(GetEvents());
                eventsContext.SaveChanges();
            }
        }

        private static IEnumerable<Location> GetEventsLocations()
        {
            return new List<Location>
            {
                new Location
                {
                    Lat = 47.6062M,
                    Lon = -122.33207M,
                    City = "Seattle",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6739M,
                    Lon =  -122.1215M,
                    City = "Redmond",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.7623M,
                    Lon = -122.2054M,
                    City = "Bothell",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6814M,
                    Lon = -122.2087M,
                    City = "Kirkland",
                    State = "WA"
                },
                new Location
                {
                    Lat = 47.6103M,
                    Lon = -122.2006M,
                    City = "Bellevue",
                    State = "WA"
                },
                new Location
                {
                    Lat = 39.2974M,
                    Lon = -78.4342M,
                    City = "Capon Bridge",
                    State = "WV"
                },
                new Location
                {
                    Lat = 37.7775M,
                    Lon = -81.1748M,
                    City = "Beckley",
                    State = "WV"
                },
                new Location
                {
                    Lat = 39.3321M,
                    Lon = -77.9048M,
                    City = "Kearneysville",
                    State = "WV"
                },
                new Location
                {
                    Lat = 38.3510M,
                    Lon = -81.6278M,
                    City = "Charleston",
                    State = "WV"
                },
                new Location
                {
                    Lat = 37.3696M,
                    Lon = -81.0958M,
                    City = "Princeton",
                    State = "WV"
                },
            };
        }

        private static IEnumerable<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 1,
                    LocationId = 1,
                    Description = "Seattle Tech Career Fair:Exclusive Tech Hiring Event-New",
                    Name = "Tech Career Fair",
                    Price = 50.9M,
                    PictureUrl = "http://externaleventsbaseurltobereplaced/api/pic/1",
                    StartTime = new DateTime(2021,08,15,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,15,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 1,
                    Description = "Develop a Successful GreenTech / CleanTech Startup Business Today",
                    Name = "GreenTech / CleanTech",
                    Price = 50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/2",
                    StartTime = new DateTime(2021,08,16,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,16,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 3,
                    LocationId = 3,
                    Description = "Thinkful Webinar | Getting Started in Tech",
                    Name = "Getting Started in Tech",
                    Price=50.9M,
                    PictureUrl = "http://externaleventsbaseurltobereplaced/api/pic/3",
                    StartTime = new DateTime(2021,08,17,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,17,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 4,
                    Description = "Develop a Successful Healthcare Tech Startup Business Hackathon | Healthcare Tech Entrepreneurship Workshop | Medtech Entrepreneur Training",
                    Name = "Healthcare Tech Startup Business",
                    Price = 50.9M,
                    PictureUrl = "http://externaleventsbaseurltobereplaced/api/pic/4",
                    StartTime = new DateTime(2021,08,18,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,18,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 3,
                    EventCreaterId = 2,
                    LocationId = 3,
                    Description = "Develop a Successful Food Tech Startup Business Hackathon | Startup Hackathon | Entrepreneur Hackathon | Entrepreneurship Hackathon",
                    Name = "Food Tech Startup Business",
                    Price = 50.9M,PictureUrl="http://externaleventsbaseurltobereplaced/api/pic/5",
                    StartTime = new DateTime(2021,08,19,5,10,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,19,6,10,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 4,
                    EventCreaterId = 6,
                    LocationId = 6,
                    Description = "Join us at The River House in Capon Bridge, WV every Saturday from 12-3 for a free drop in art activity. All materials provided!",
                    Name = "Art for All- Free Art Activity for all ages!",
                    Price = 0.0M,
                    PictureUrl = "",
                    StartTime = new DateTime(2021,07,31,12,00,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,07,31,3,00,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 4,
                    EventCreaterId = 7,
                    LocationId = 7,
                    Description = "The Ecstasy of Gold is Beckley Art Center's newest solo exhibition featuring the collage artistry of artist, Psychoflauge.",
                    Name = "The Ecstasy of Gold | Exhibition Opening Reception",
                    Price = 0.0M,
                    PictureUrl = "",
                    StartTime = new DateTime(2021,08,6,6,00,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,6,7,30,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 4,
                    EventCreaterId = 8,
                    LocationId = 8,
                    Description = "Join your friends at a top judged festival in America! 45th Annual Fall Mountain Heritage Arts & Crafts Festival 2021, FREE WV Wine Tastings",
                    Name = "45th Annual Fall Mountain Heritage Arts & Crafts Festival",
                    Price = 0.0M,
                    PictureUrl = "",
                    StartTime = new DateTime(2021,09,24,10,00,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,09,26,5,00,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 4,
                    EventCreaterId = 9,
                    LocationId = 9,
                    Description = "FIGURE DRAWING @ Studio 3D July - August Session Starting July 29th we're hosting 4 Figure Drawing sessions!",
                    Name = "Figure Drawing July-August Session",
                    Price = 40.0M,
                    PictureUrl = "",
                    StartTime = new DateTime(2021,07,27,6,00,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,27,9,00,20,DateTimeKind.Local),
                },
                new Event
                {
                    EventsTypeId = 4,
                    EventCreaterId = 10,
                    LocationId = 10,
                    Description = "We will be painting a Sunflower in the style of Van Gogh. All materials are included to paint your masterpiece. No experience necessary, our",
                    Name = "Peak Of The Bloom Sunflower Painting Class",
                    Price = 29.99M,
                    PictureUrl = "",
                    StartTime = new DateTime(2021,08,14,5,00,20,DateTimeKind.Local),
                    EndTime = new DateTime(2021,08,14,8,00,20,DateTimeKind.Local),
                },

            };
        }

        private static IEnumerable<EventsType> GetEventsType()
        {
            return new List<EventsType>
            {
                new EventsType
                {
                    Type="For Kids"
                },
                new EventsType
                {
                    Type = "Fittness&Health"
                },
                new EventsType
                {
                    Type = "Technology"
                },
                new EventsType
                {
                    Type = "Art"
                },
                new EventsType
                {
                    Type = "Food&Drink"
                }
            };
        }

        private static IEnumerable<EventsHost> GetEventsHosts()
        {
            return new List<EventsHost>
            {
                new EventsHost
                {
                    Creater = "Tech Career Fair"
                },
                new EventsHost
                {
                    Creater = "Atechup.com"
                },
                new EventsHost
                {
                    Creater = "Thinkful Seattle"
                },
                new EventsHost
                {
                    Creater = "Women Hack"
                },
                new EventsHost
                {
                    Creater = " AnalyticsWEEK"
                },
                new EventsHost
                {
                    Creater = "The River House"
                },
                new EventsHost
                {
                    Creater = "Beckley Art Center"
                },
                new EventsHost
                {
                    Creater = "Jefferson County Chamber of Commerce, Inc."
                },
                new EventsHost
                {
                    Creater = "Tamarack Foundation for the Arts"
                },
                new EventsHost
                {
                    Creater = "The Bronze Look, LLC"
                }
            };
        }
    }
}
