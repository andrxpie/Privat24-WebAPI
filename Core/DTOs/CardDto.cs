using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
  public class CardDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public int CVV { get; set; }
    public DateTime ExpireDate { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public double Balance { get; set; }
  }
}
