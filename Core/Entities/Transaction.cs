using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
  public class Transaction
  {
    public int Id { get; set; }
    public int Value { get; set; }
    public Card Sender { get; set; }
    public int SenderId { get; set; }
    public object Reciever { get; set; } // phone number || another card
  }
}
