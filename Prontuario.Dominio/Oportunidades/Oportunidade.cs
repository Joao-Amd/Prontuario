﻿using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Oportunidades
{
    public class Oportunidade
    {
        public Oportunidade() { }

        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataHora { get; private set; }

        //
        public virtual Paciente Paciente { get; private set; }
    }
}
