﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Migrations;



namespace DTO
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string fotoCedula { get; set; }
        public string? fotoPerfil { get; set; }

        // Atributos para 2FA
        public string? TwoFactorSecretKey { get; set; }  // Clave secreta de 2FA
        public bool IsTwoFactorEnabled { get; set; } = false;  // Indica si 2FA está habilitado

        [Required]
        [ForeignKey("Rol")]
        public int IdRol { get; set; }

        public ICollection<Placas>? Placas { get; set; }


    }
}
