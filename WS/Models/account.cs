﻿using System;

namespace WS.Models
{
    public class account
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string apelido { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime ultimo_acesso { get; set; }
        public bool ativo { get; set; }
        public bool resetar_senha { get; set; }
    }
}