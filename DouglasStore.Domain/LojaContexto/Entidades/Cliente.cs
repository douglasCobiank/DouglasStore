using System.Collections.Generic;
using System;
using DouglasStore.Domain.LojaContexto.ObjetoValor;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Cliente
    {
        //Solid
        //s = Apenas o que é da classe na classe.(Single Responsability Principal) 
        //o = Open Closed(Aberto para instanciação e fechado para modificação)
        //l = 
        //i =
        //d =
        public Cliente(
            Nome nome,
            Documento _documento,
            Email _email,
            string _telefone,
            string _endereco
        ){
            Nome = nome;
            Documento = _documento;
            Email = _email;
            Telefone = _telefone;
            Enderecos = new List<Endereco>();
        }
        public Nome Nome{get; private set;}
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos { get; private set; }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}