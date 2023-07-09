using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UserController : BaseApiController
{
    private readonly PruebaEntityFrameworkContext _context;

    public UserController(PruebaEntityFrameworkContext context)
    {
        _context = context;
    }
}