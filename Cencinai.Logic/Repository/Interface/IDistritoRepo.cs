﻿using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Logic.Repository.Interface
{
    public interface IDistritoRepo
    {
        Task<IEnumerable<DistritoModel>> ObtenerDistritos(int cantonId);
    }
}
