﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using papara_firstweek_hwApp.API.Exceptions;
using papara_firstweek_hwApp.API.Extensions;
using papara_firstweek_hwApp.API.Models.DTOs;
using papara_firstweek_hwApp.API.Models.Shared;
using System.Xml.Linq;

namespace papara_firstweek_hwApp.API.Models.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            //userRepository = new UserRepository(); SOLİD prensiplerine uymuyor (newlenmiş, bağlılık var)
        }



        public ResponseDto<List<UserDto>> GetAll()
        {
            var users = _userRepository.GetAll();

            throw new ClientValidationError("client hatası. format yanlış");

            var userDtos = _mapper.Map<List<UserDto>>(users);


            return ResponseDto<List<UserDto>>.Success(userDtos);
        }


        public ResponseDto<int> Add(UserAddDtoRequest request)
        {
            var id = new Random().Next(1, 1000);
            var user = new User
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age!.Value,
            };
            _userRepository.Add(user);
            return ResponseDto<int>.Success(id);
        }

        public void Update(UserUpdateDtoRequest request)
        {
            User user = new User
            {
                Id = request.Id,
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age
            };
            _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public UserDto GetById(int id)
        {
            var user = _userRepository.GetById(id);

            return _mapper.Map<UserDto>(user);
        }
    }
}
