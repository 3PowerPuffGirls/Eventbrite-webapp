﻿using EventsAPI.Data;
using EventsAPI.Domains;
using EventsAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventsContext _context;
        private readonly IConfiguration _config;
        public EventsController(IConfiguration config, EventsContext context)
        {
            _context = context;
            _config = config;

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Events(
            [FromQuery] int pageIndex = 0,
            [FromQuery] int pageSize = 6)
        {
            var itemsCount = _context.Events.LongCountAsync();
            var items = await _context.Events
                .OrderByDescending(c => c.StartTime)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();

            items = ChangePictureUrl(items);
            var model = new PaginatedEventsViewModel
            {
                PageIndex = pageIndex,
                PageSize = items.Count,
                Count = itemsCount.Result,
                Data = items
            };
            return Ok(model);
        }

        private List<Event> ChangePictureUrl(List<Event> items)
        {
            items.ForEach(item =>
                item.PictureUrl = item.PictureUrl.Replace(
                    "http://externaleventsbaseurltobereplaced", _config["ExternalEventUrl"]));
            return items;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> EventsByPrice(
            [FromQuery] int price = 0,
            [FromQuery] int pageIndex = 0,
            [FromQuery] int pageSize = 3
            )
        {
            var itemsCount = _context.Events.Where(c => c.Price == price).LongCountAsync();
            var items = await _context.Events.OrderByDescending(c => c.StartTime)
                .Where(c => c.Price == price)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
                

            items = ChangePictureUrl(items);
            var model = new PaginatedEventsViewModel
            {
                PageIndex = pageIndex,
                PageSize = items.Count,
                Count = itemsCount.Result,
                Data = items
            };
            return Ok(model);
        }

    }
}
