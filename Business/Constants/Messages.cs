﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is Added";
        public static string ProductNameInvalid = "Product Name is Invalid ";
        public static string MaintenanceTime = "System is closed";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountOfCategoryError= "A category must include at most 15 products";
        public static string ProductNameAlreadyExistError="Product already exist";
        public static string CategoryLimitExceded = "Category limit exceded";
        public static string AuthorizationDenied="Authorization Denied";
        public static string UserRegistered="Successfully registered";
        public static string UserNotFound="User not exist";
        public static string PasswordError="Wrong password";
        public static string SuccessfulLogin="Successful login";
        public static string UserAlreadyExists="User already exist";
        public static string AccessTokenCreated="Token Created";
    }
}
