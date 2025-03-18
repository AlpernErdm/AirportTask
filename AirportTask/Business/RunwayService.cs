using AirportTask.Context;
using AirportTask.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace AirportTask.Business
{
    public class RunwayService:IRunwayService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RunwayService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task TransferRunwayDataAsync()
        {
            var ver22Data = await _context.Runway22.ToListAsync();

            // AutoMapper ile transferin daha clean olduğunu düşündüm
            var ver19Data = _mapper.Map<List<Runway19>>(ver22Data);

            await _context.Runway19.AddRangeAsync(ver19Data);
            await _context.SaveChangesAsync();
        }
    }
}
