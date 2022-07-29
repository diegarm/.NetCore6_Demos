using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Application.ViewModels;
using VendingMachine.Domain.Commands;

namespace VendingMachine.Application.Mapping
{
    public  class DomainToViewModelReverseMapping: Profile
    {
        public DomainToViewModelReverseMapping()
        {
            CreateMap<BuyViewModel, RegisterBuyCommand>().ReverseMap();
            CreateMap<CashInViewModel, RegisterCashInCommand>().ReverseMap();
        }
    }
}
