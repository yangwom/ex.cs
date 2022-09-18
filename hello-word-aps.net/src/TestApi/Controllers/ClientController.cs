using Microsoft.AspNetCore.Mvc;

namespace TestApi.Core;

[ApiController]
[Route("[Controller]")]

public class ClientsController : ControllerBase
{
    private static List<Client> _client = new();
    private static int _nextId = 1;

    [HttpGet]

    public ActionResult GetClient()
    {


        return StatusCode(200, _client);
    }

    [HttpPost]

    public ActionResult Create(ClientRequest request)
    {
        var client = request.CreateClient(_nextId++);
        _client.Add(client);

        return StatusCode(201, client);
    }

    [HttpPut("{id}")]

    public ActionResult Update(int id, ClientRequest request)
    {
        var client = _client.FirstOrDefault(c => c.Id == id);
        if (client == null)
        {
            return NotFound("Client not found");
        }

        request.UpdateClient(client);

        return Ok(client);
    }

    [HttpDelete]

    public ActionResult Delete(int Id)
    {
        var RemoveClient = _client.RemoveAll(c => c.Id == Id);

        if (RemoveClient == 0) return NotFound("Client not Found");
          
          return NoContent();
    }
}