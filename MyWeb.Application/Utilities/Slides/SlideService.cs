using MyWeb.Application.System.Roles;
using MyWebLapTop.Data.EF;
using MyWebLapTop.Data.Entities;
using MyWeb.ViewModels.System.Roles;
using MyWeb.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly MyWebLapTopDbContext _context;

        public SlideService(MyWebLapTopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}