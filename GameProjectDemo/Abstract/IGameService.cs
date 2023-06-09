﻿using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Sell(Game game);
    }
}