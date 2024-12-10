using Microsoft.AspNetCore.Mvc.RazorPages;
using Testing_Dot_Net.Data;
using Testing_Dot_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }
    public List<Person> People { get; set; } = new List<Person>();

    public void OnGet()
    {
        // Fetch all records from the database
        People = _context.People.ToList();
    }
}
