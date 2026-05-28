using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models;

public class TestClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{Name} {LastName}";

    public string Description { get; set; }
}
