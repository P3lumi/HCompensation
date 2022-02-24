using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HCompensation.Data;
using HCompensation.Models.ViewModels;
using HCompensation.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public class CarOwnerService : ICarOwnerService
    {
        private readonly ICarServiceRepo<CarOwner> _carServiceRepo;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;

        public CarOwnerService(ICarServiceRepo<CarOwner> carServiceRepo, IMapper mapper, IOptions<CloudinarySetting> config)
        {
            _carServiceRepo = carServiceRepo;
            _mapper = mapper;
            var acc = new Account(config.Value.CloudName, config.Value.ApiKey, config.Value.ApiSecret);
            _cloudinary = new Cloudinary(acc);
        }
        public async Task<bool> AddCarOwner(CarOwnerVM carOwnerVM)
        {
            var CarDocumentUrl = UploadFile(carOwnerVM.CarDocument).Url.ToString();
            var PurchaseReceiptUrl = UploadFile(carOwnerVM.PurchaseReceipt).Url.ToString();
            var carOwner = AutoMapperProfile.Map(carOwnerVM, new string[] { CarDocumentUrl, PurchaseReceiptUrl });
                  
            var response = await _carServiceRepo.Add(carOwner);
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

