using System.Collections.Generic;
using System;
using DouglasStore.Domain.LojaContexto.ObjetoValor;
using System.Linq;
using FluentValidator;

namespace DouglasStore.Domain.LojaContexto.Entidades
{
    public class Cliente : Notifiable
    {
        //Solid
        //s = Apenas o que é da classe na classe.(Single Responsability Principal) 
        //o = Open Closed(Aberto para instanciação e fechado para modificação)
        //l = 
        //i =
        //d =
        private readonly IList<Endereco> _addEndereco;
        public Cliente(
            Nome nome,
            Documento _documento,
            Email _email,
            string _telefone,
            Endereco _endereco
        ){
            Nome = nome;
            Documento = _documento;
            Email = _email;
            Telefone = _telefone;
            _addEndereco = new List<Endereco>();
        }
        public Nome Nome{get; private set;}
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos => _addEndereco.ToArray();

        public void AddEndereco(Endereco endereco){
            _addEndereco.Add(endereco);
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}