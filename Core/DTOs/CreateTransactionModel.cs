using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
  public class CreateTransactionModel
  {
    public int Value { get; set; }
    public Card Sender { get; set; }
    public int SenderId { get; set; }
    public object Reciever { get; set; }
  }
}
