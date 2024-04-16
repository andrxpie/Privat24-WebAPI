using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    internal class CardsService : ICardsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Card> cardsR;

        private readonly UserManager<User> userManager;

        public CardsService(IMapper mapper, 
                            IRepository<Card> cardsR,
                            UserManager<User> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public Task Create(CreateCardModel model)
        {
            
        }

        public Task Edit(EditCardModel model)
        {
            
        }

        public IEnumerable<CardDto> GetAllByUser(string userId)
        {
            
        }

        public Task Remove(int id)
        {
            
        }
    }
}
