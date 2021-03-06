﻿using Randy.DomainCore.DTO;
using Randy.FrameworkCore;
using Randy.Infrastructure;
using Randy.Infrastructure.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randy.DomainCore
{
    public interface IUserService : IDependentInjection
    {

        ReturnModel<User> Login(string userName, string password, string ip="");
        ReturnModel SignUp(SignUpInput input);
        ReturnModel SetUserInfo(UserInfo info);
        ReturnModel<UserDetail> GetUserDetail(int userId);
        ReturnPagedModel<ls_user_info> GetUserInfos(QueryPagedModel query);
    }

}
