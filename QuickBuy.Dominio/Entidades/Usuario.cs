﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        /// <summary>
        /// Usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validated()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada");
        }
    }
}
