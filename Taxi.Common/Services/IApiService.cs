﻿using Taxi.Common.Models;
using System.Threading.Tasks;

namespace Taxi.Common.Services
{
    public interface IApiService
    {
        Task<Response> ChangePasswordAsync(string urlBase, string servicePrefix, string controller, ChangePasswordRequest changePasswordRequest, string tokenType, string accessToken);
        Task<Response> PutAsync<T>(string urlBase, string servicePrefix, string controller, T model, string tokenType, string accessToken);
        Task<Response> RecoverPasswordAsync(string urlBase, string servicePrefix, string controller, EmailRequest emailRequest);
        Task<Response> RegisterUserAsync(string urlBase, string servicePrefix, string controller, UserRequest userRequest);
        Task<Response> GetTaxiAsync(string plaque, string urlBase, string servicePrefix, string controller);
        Task<bool> CheckConnectionAsync(string url);
        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);
        Task<Response> GetUserByEmail(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, EmailRequest request);
    }
}
