﻿using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICardsService
    {
        Task Create(CreateCardModel model);
        async IEnumerable<CardDto> GetAllByUser(string userId);
        Task Edit(EditCardModel model);
        void Remove(int cardId);
    }
}
