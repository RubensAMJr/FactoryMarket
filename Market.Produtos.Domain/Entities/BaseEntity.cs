﻿namespace Market.Produtos.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public bool Deleted { get; protected set; }

        public void Delete()
        {
            Deleted = true;
        }
    }
}
