﻿using MDispatch.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;

namespace MDispatch.Service
{
    public class OrderGet
    {
        public int ActiveOreder(string token, string status, ref string description, ref List<Shipping> shippings)
        {
            IRestResponse response = null;
            string content = null;
            try
            {
                RestClient client = new RestClient("http://192.168.0.103:8888");
                RestRequest request = new RestRequest("Mobile/ActiveOreder", Method.POST);
                request.AddHeader("Accept", "application/json");
                request.Parameters.Clear();
                request.AddParameter("token", token);
                request.AddParameter("status", status);
                response = client.Execute(request);
                content = response.Content;
            }
            catch (Exception)
            {
                return 4;
            }
            if (content == "" || response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return 4;
            }
            else
            {
                return GetData(content, ref description, ref shippings);
            }
        }

        public int SavePikedUp(string token, string idOrder, string name, string contactName, string address, string city, string state, string zip, string phone, string email, ref string description)
        {
            IRestResponse response = null;
            string content = null;
            try
            {
                RestClient client = new RestClient("http://192.168.0.103:8888");
                RestRequest request = new RestRequest("Mobile/SavePikedUp", Method.POST);
                request.AddHeader("Accept", "application/json");
                request.Parameters.Clear();
                request.AddParameter("token", token);
                request.AddParameter("idOrder", idOrder);
                request.AddParameter("name", name);
                request.AddParameter("contactName", contactName);
                request.AddParameter("address", address);
                request.AddParameter("city", city);
                request.AddParameter("state", state);
                request.AddParameter("zip", zip);
                request.AddParameter("phone", phone);
                request.AddParameter("email", email);
                response = client.Execute(request);
                content = response.Content;
            }
            catch (Exception)
            {
                return 4;
            }
            if (content == "" || response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return 4;
            }
            else
            {
                return GetData(content, ref description);
            }
        }

        private int GetData(string respJsonStr, ref string description, ref List<Shipping> shippings)
        {
            respJsonStr = respJsonStr.Replace("\\", "");
            respJsonStr = respJsonStr.Remove(0, 1);
            respJsonStr = respJsonStr.Remove(respJsonStr.Length - 1);
            var responseAppS = JObject.Parse(respJsonStr);
            string status = responseAppS.Value<string>("Status");
            if (status == "success")
            {
                shippings = JsonConvert.DeserializeObject<List<Shipping>>(responseAppS.
                        SelectToken("ResponseStr").ToString());
                return 3;
            }
            else
            {
                description = responseAppS
                    .Value<string>("description");
                return 2;
            }

        }

        private int GetData(string respJsonStr, ref string description)
        {
            respJsonStr = respJsonStr.Replace("\\", "");
            respJsonStr = respJsonStr.Remove(0, 1);
            respJsonStr = respJsonStr.Remove(respJsonStr.Length - 1);
            var responseAppS = JObject.Parse(respJsonStr);
            string status = responseAppS.Value<string>("Status");
            description = responseAppS.Value<string>("Description");
            if (status == "success")
            {
                return 3;
            }
            else
            {
                description = responseAppS
                    .Value<string>("description");
                return 2;
            }
        }
    }
}