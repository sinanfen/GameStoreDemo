using GameStoreDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Entities
{
    public class Sale : IEntity
    {
        public int SaleId { get; set; }
        public string GameName { get; set; }
        public string PlayerName { get; set; }

    }
}
