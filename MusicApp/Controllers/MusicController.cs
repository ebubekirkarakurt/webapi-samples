using Microsoft.AspNetCore.Mvc;
using MusicApp.Models;
using MusicApp.Repositories;
using MusicApp.Services;



[ApiController]
[Route("api/musics")]
public class MusicController : ControllerBase{
    private IRepositoryMethods<Musics> repo;

    public MusicController(MusicRepository repository)
    {
        repo = repository;
    }

    [HttpGet]
    public ActionResult<List<Musics>> GetAll(){
        return Ok(repo.GetAll());
    }

    [HttpGet("{id:int}")]
    public Musics GetOne(int id){
        return repo.GetOne(id);
    }

    [HttpPost]
    public ActionResult CreateItem(Musics music){
        repo.CreateItem(music);
        return Ok("New music created!");
    }

    [HttpPut]
    public IActionResult Update(int id, Musics item){
        repo.Update(id,item);
        return Ok("Music updated!");
    }

    [HttpDelete]
    public IActionResult DeleteAll(){
        repo.DeleteAll();
        return Ok("All musics were deleted successfully!");
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteOne(int id){
        repo.DeleteOne(id);
        return Ok("Music was deleted successfully!");
    }

}