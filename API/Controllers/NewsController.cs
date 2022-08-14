using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetNewsAll()
        {
            var news = await newsService.GetAllAsync();
            return Ok(news);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            var news = await newsService.GetManyAsync(item => item.Id.ToString().Contains(id.ToString()));

            return Ok(news);
        }

        [HttpGet("feeds")]
        public async Task<IActionResult> GetFeedsAll()
        {
            var feeds = await newsService.GetAllFeedsAsync();

            return Ok(feeds);
        }
    }
}
