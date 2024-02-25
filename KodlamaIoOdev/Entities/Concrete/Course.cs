using KodlamaIoOdev.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.Entities.Concrete;

public class Course : BaseEntity
{
    public int InstructorId { get; set; }
    public int CategoryId { get; set; } 
    public int Price { get; set; }
    public int CompleationPercent { get; set; } 
}
