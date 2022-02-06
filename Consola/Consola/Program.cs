using System;
using Modelo.Entidades;
using Modelo;
using System.Collections.Generic;



namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creacion de lenguajes

            language ingles = new language()
            {
                name = "Ingles",
                last_update = new DateTime(2022 - 02 - 12)

            };

            language español = new language()
            {
                name = "español",
                last_update = new DateTime(2022 - 02 - 22)

            };
            language italiano = new language()
            {
                name = "italiano",
                last_update = new DateTime(2022 - 03 - 12)

            };
            List<language> listalenguaje = new List<language>()
            {
                ingles,español,italiano
            };
            /*crecion de films */
            film academia = new film()
            {
                title = "academia",
                description = "epicodrag",
                release_year = 2006,

                language = ingles
                
            };
            film RF = new film()
            {
                title = "RF7",
                description = "carreras",
                release_year = 2026,

                language = español

            };
            film MSC = new film()
            {
                title = "3MSC",
                description = "drama",
                release_year = 2019,

                language = ingles

            };
            film mario = new film()
            {
                title = "mario",
                description = "epico",
                release_year = 2015,

                language = italiano

            };
            film superman = new film()
            {
                title = "superman",
                description = "accion",
                release_year = 2016,

                language = español

            };
            film batman = new film()
            {
                title = "batman",
                description = "accion",
                release_year = 2008,

                language = ingles

            };
            List<film> listafilm = new List<film>()
            {
                batman,superman,mario,MSC,RF,academia
            };
            //inventario
            inventory uno = new inventory()
            {
                films = batman,
                story_id = 1,
                last_update = new DateTime(2022-12-03)
            };
            inventory dos = new inventory()
            {
                films = superman,
                story_id = 1,
                last_update = new DateTime(2022 - 05 - 05)
            };
            inventory tres = new inventory()
            {
                films = mario,
                story_id = 1,
                last_update = new DateTime(2005 - 12 - 10)
            };
            List<inventory> listinventaryo = new List<inventory>()
            {
                uno,dos,tres
            };
        }
    }
}
