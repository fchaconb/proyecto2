﻿// <auto-generated />
using System;
using DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241118023220_UsuarioTwoFactor")]
    partial class UsuarioTwoFactor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DTO.CatalogoInfracciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CatalogoInfracciones");
                });

            modelBuilder.Entity("DTO.Disputas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("declaracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idJuez")
                        .HasColumnType("int");

                    b.Property<int>("idMulta")
                        .HasColumnType("int");

                    b.Property<int>("idOficial")
                        .HasColumnType("int");

                    b.Property<int>("idUsuarioFinal")
                        .HasColumnType("int");

                    b.Property<bool>("necesitaDeclaracion")
                        .HasColumnType("bit");

                    b.Property<string>("razon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resolucion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("idJuez");

                    b.HasIndex("idMulta");

                    b.HasIndex("idOficial");

                    b.HasIndex("idUsuarioFinal");

                    b.ToTable("disputas");
                });

            modelBuilder.Entity("DTO.Facturas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMulta")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaPago")
                        .HasColumnType("datetime2");

                    b.Property<string>("metodoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("subTotal")
                        .HasColumnType("float");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("DTO.Multas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdInfractor")
                        .HasColumnType("int");

                    b.Property<int>("IdOficial")
                        .HasColumnType("int");

                    b.Property<string>("apellidoInfractor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedulaInfractor")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("fotoSinpe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("latitud")
                        .HasColumnType("real");

                    b.Property<float>("longitud")
                        .HasColumnType("real");

                    b.Property<string>("nombreInfractor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pagada")
                        .HasColumnType("bit");

                    b.Property<bool>("resuelta")
                        .HasColumnType("bit");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdInfractor");

                    b.HasIndex("IdOficial");

                    b.ToTable("Multas");
                });

            modelBuilder.Entity("DTO.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Leido")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notificacions");
                });

            modelBuilder.Entity("DTO.Permisos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("DTO.Placas", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Placas");
                });

            modelBuilder.Entity("DTO.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DTO.RolPermiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPermiso")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RolPermisos");
                });

            modelBuilder.Entity("DTO.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DTO.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DTO.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<bool>("IsTwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("TwoFactorSecretKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoCedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Correo")
                        .IsUnique();

                    b.HasIndex("IdRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DTO.infraccionMulta", b =>
                {
                    b.Property<int>("CatalogoInfraccionesId")
                        .HasColumnType("int");

                    b.Property<int>("MultasId")
                        .HasColumnType("int");

                    b.HasKey("CatalogoInfraccionesId", "MultasId");

                    b.HasIndex("MultasId");

                    b.ToTable("infraccionMulta");
                });

            modelBuilder.Entity("DTO.multaPlaca", b =>
                {
                    b.Property<int>("MultasId")
                        .HasColumnType("int");

                    b.Property<string>("PlacasId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MultasId", "PlacasId");

                    b.HasIndex("PlacasId");

                    b.ToTable("multaPlacas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DTO.Disputas", b =>
                {
                    b.HasOne("DTO.Usuario", null)
                        .WithMany()
                        .HasForeignKey("idJuez")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DTO.Multas", null)
                        .WithMany()
                        .HasForeignKey("idMulta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DTO.Usuario", null)
                        .WithMany()
                        .HasForeignKey("idOficial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DTO.Usuario", null)
                        .WithMany()
                        .HasForeignKey("idUsuarioFinal")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Multas", b =>
                {
                    b.HasOne("DTO.Usuario", null)
                        .WithMany()
                        .HasForeignKey("IdInfractor")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("DTO.Usuario", null)
                        .WithMany()
                        .HasForeignKey("IdOficial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Placas", b =>
                {
                    b.HasOne("DTO.Usuario", null)
                        .WithMany("Placas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("DTO.Ticket", b =>
                {
                    b.HasOne("DTO.User", null)
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Usuario", b =>
                {
                    b.HasOne("DTO.Rol", null)
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.infraccionMulta", b =>
                {
                    b.HasOne("DTO.CatalogoInfracciones", null)
                        .WithMany("infraccionMultas")
                        .HasForeignKey("CatalogoInfraccionesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Multas", null)
                        .WithMany("infraccionMultas")
                        .HasForeignKey("MultasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.multaPlaca", b =>
                {
                    b.HasOne("DTO.Multas", null)
                        .WithMany("multaPlacas")
                        .HasForeignKey("MultasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Placas", null)
                        .WithMany("multaPlacas")
                        .HasForeignKey("PlacasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.CatalogoInfracciones", b =>
                {
                    b.Navigation("infraccionMultas");
                });

            modelBuilder.Entity("DTO.Multas", b =>
                {
                    b.Navigation("infraccionMultas");

                    b.Navigation("multaPlacas");
                });

            modelBuilder.Entity("DTO.Placas", b =>
                {
                    b.Navigation("multaPlacas");
                });

            modelBuilder.Entity("DTO.User", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DTO.Usuario", b =>
                {
                    b.Navigation("Placas");
                });
#pragma warning restore 612, 618
        }
    }
}
