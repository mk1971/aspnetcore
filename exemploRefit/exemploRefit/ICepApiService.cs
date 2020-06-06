﻿using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace exemploRefit
{
    public interface ICepApiService
    {
        [Get("/ws/(cep)/json")]
        Task<CepResponse> GetAdressAsync(string cep);
    }
}
