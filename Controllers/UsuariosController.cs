using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsuarios()
    {
        return Ok(new { mensaje = "API funcionando correctamente" });
    }
}