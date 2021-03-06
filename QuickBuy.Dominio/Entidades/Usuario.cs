﻿using System.Collections.Generic;
using System;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        
        //user pode ter um ou nenhum pedido
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - Email deve estar preenchido");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Crítica - Senha deve estar preenchido");
        }
    }        
}
