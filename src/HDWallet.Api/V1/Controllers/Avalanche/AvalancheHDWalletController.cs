﻿using System;
using HDWallet.Avalanche;
using HDWallet.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HDWallet.Api.V1.Controllers.Avalanche
{
    [ApiController]
    [ApiVersion( "1.0" )]
    [Route("api/v{version:apiVersion}")]
    public class AvalancheHDWalletController : Secp256k1HDWalletController<AvalancheWallet>
    {
        public AvalancheHDWalletController(
            ILogger<AvalancheHDWalletController> logger,
            Func<IHDWallet<AvalancheWallet>> hDWallet) : base(logger, hDWallet) {}

        [HttpGet("/Avalanche/{account}/external/{index}")]
        public ActionResult<string> GetDeposit(uint account, uint index)
        {
            return base.DepositWallet(account, index);
        }

        [HttpGet("/Avalanche/{account}/internal/{index}")]
        public ActionResult<string> GetChange(uint account, uint index)
        {
            return base.ChangeWallet(account, index);
        }
    }
}