﻿using Microsoft.AspNetCore.Http;
using Nest_BackFront.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_BackFront.Services
{
    public class LayoutServices
    {
        private AppDbContext _context { get; }
        private IHttpContextAccessor _accessor { get; }

        public LayoutServices(AppDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
