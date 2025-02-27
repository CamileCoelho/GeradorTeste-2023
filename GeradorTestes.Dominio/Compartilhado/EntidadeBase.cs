﻿namespace GeradorTestes.Dominio
{
    public abstract class EntidadeBase<T>
    {
        public int Id { get; set; }        

        public abstract void Atualizar(T registro);
    }
}