﻿using Cencinai.Logic.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cencinai.Web.Helper
{
    public class SelectListHelper
    {
        public static List<SelectListItem> ObtenerListaProvincia(IEnumerable<ProvinciaModel> provincias)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (provincias != null)
            {
                foreach (var item in provincias)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = item.Nombre,
                        Value = item.Id.ToString()
                    });
                }
            }

            return selectList;
        }

        public static List<SelectListItem> ObtenerListaCanton(IEnumerable<CantonModel> cantones)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (cantones != null)
            {
                foreach (var item in cantones)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = item.Nombre,
                        Value = item.Id.ToString()
                    });
                }
            }

            return selectList;
        }

        public static List<SelectListItem> ObtenerListaDistrito(IEnumerable<DistritoModel> distritos)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (distritos != null)
            {
                foreach (var item in distritos)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = item.Nombre,
                        Value = item.Id.ToString()
                    });
                }
            }

            return selectList;
        }

        public static List<SelectListItem> ObtenerListaResponsables(IEnumerable<ResponsableModel> responsables)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (responsables != null)
            {
                foreach (var item in responsables)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = $"{item.Nombre} {item.PrimerApellido} {item.SegundoApellido}",
                        Value = item.Id.ToString()
                    });
                }
            }

            return selectList;
        }

        public static List<SelectListItem> ObtenerListaCategorias(IEnumerable<CategoriaModel> categorias)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (categorias != null)
            {
                foreach (var item in categorias)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = item.Abreviatura,
                        Value = item.Id.ToString()
                    });
                }
            }

            return selectList;
        }
    }
}