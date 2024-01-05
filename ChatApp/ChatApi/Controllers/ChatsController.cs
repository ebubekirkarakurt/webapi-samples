using ChatEntities;
using ChatRepositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/chats")]
public class ChatsController : ControllerBase
{
    private RepositoryContext _context;

    public ChatsController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Post(Chats chat)
    {
        if (chat.Equals(null))
            return BadRequest();
        _context.Chats.Add(chat);
        _context.SaveChanges();
        return Created("Chat created!", chat);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Chats);
    }


}