﻿namespace Prontuario.Dominio.Receitas
{
    public class Receita
    {
        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; set; }

        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
