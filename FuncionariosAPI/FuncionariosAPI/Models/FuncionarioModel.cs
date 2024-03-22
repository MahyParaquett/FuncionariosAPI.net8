﻿using FuncionariosAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace FuncionariosAPI.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set;}

        public DepartamentoEnum Departamento { get; set;}

        public bool Ativo { get; set;}

        public TurnoEnum Turno { get; set;}

        public DateTime DataDeCriação { get; set;} = DateTime.Now.ToLocalTime();

        public DateTime DataDeAlteracao { get; set;} = DateTime.Now.ToLocalTime();



    }
}