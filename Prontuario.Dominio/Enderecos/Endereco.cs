﻿using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Enderecos
{
    public class Endereco
    {
        public Endereco() { }

        public Endereco(Paciente paciente, string rua, string cep, int numeroEndereco, string cidade, string uf, string detalhes, string referencia) 
        {
            Id = Guid.NewGuid();
            CodigoPaciente = paciente.Id;
            Paciente = paciente;
            Rua = rua;
            Cep = cep;
            NumeroEndereco = numeroEndereco;
            Cidade = cidade;
            Uf = uf;
            Detalhes = detalhes;
            Referencia = referencia;
        }

        public Guid Id { get; private set; }
        public Guid CodigoOrigem { get; private set; }
        public Guid CodigoPaciente { get; private set; }
        public string Rua { get; private set; }
        public string Cep { get; private set; }
        public int NumeroEndereco { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Detalhes { get; private set; }
        public string Referencia { get; private set; }
        //
        public virtual Paciente Paciente { get; private set; }

    }
}
