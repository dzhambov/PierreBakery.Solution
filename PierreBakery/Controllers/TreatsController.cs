using Microsoft.AspNetCore.Mvc;
using PierreBakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PierreBakery.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierreBakeryContext _db;

    public TreatsController(PierreBakeryContext db)
    {
      _db = db;
    }

  }
}