using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HCompensation.Data;
using HCompensation.Models.ViewModels;
using HCompensation.Service;
using HCompensation.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public class FuelStationService : IFuelStationService
    {
        private readonly IFuelStationRepo<FuelStation> _fuelStationRepo;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;

        public FuelStationService(IFuelStationRepo<FuelStation> fuelStationRepo, IMapper mapper, IOptions<CloudinarySetting> config)
        {
            _fuelStationRepo = fuelStationRepo;
            _mapper = mapper;
            var acc = new Account(config.Value.CloudName, config.Value.ApiKey, config.Value.ApiSecret);
            _cloudinary = new Cloudinary(acc);
        }
        public async Task<bool> AddFuelStation(FuelStationVM fuelStationVM)
        {
            var TicketUrl = UploadFile(fuelStationVM.Ticket).Url.ToString();
            var fuelStation = AutoMapperProfile.Map(fuelStationVM, TicketUrl);

            var response = await _fuelStationRepo.Add(fuelStation);
            if (!response)
                return false;
            return true;
        }


        public RawUploadResult UploadFile(IFormFile file)
        {
            var uploadresult = new RawUploadResult();

            using (var stream = file.OpenReadStream())
            {
                var rawUploadParams = new RawUploadParams
                {
                    File = new FileDescription(file.FileName, stream)
                };
                uploadresult = _cloudinary.Upload(rawUploadParams);
            }
            return uploadresult;
        }

    }
}
