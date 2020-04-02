﻿using ApiMobaileServise.Servise;
using DaoModels.DAO.Models;
using FluentScheduler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ApiMobaileServise.BackgraundService.InspactionDrive
{
    public class ManagerInspectionTodayTimeDriver : IJob
    {
        SqlCommandApiMobile sqlCommandApiMobile = null;
        private WebRequest tRequest = null;

        public void Execute()
        {
            InitReqvest();
            sqlCommandApiMobile = new SqlCommandApiMobile();
            List<Driver> drivers = sqlCommandApiMobile.GetDriverInDb();
            RefreshInspectionTodayTimeDriver(drivers);
        }

        private void InitReqvest()
        {
            tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", "AAAAwfAhwuA:APA91bGEjY_-E4saZ4kv2GuiJzHFAzrON0i96akHnuHls0rOqCNEgwlo3KcvLCvTHcUDYeaJxCedVvs3OAx0h9dVn9SRxyUjJpD-qXqAT49XWwAHlhhIJeMMXW9T5koFiIo0a8Sw8qei"));
            tRequest.Headers.Add(string.Format("Sender: id={0}", "832957432544"));
            tRequest.ContentType = "application/json";
        }


        private async void RefreshInspectionTodayTimeDriver(List<Driver> drivers)
        {
            foreach (var driver in drivers)
            {
                await sqlCommandApiMobile.RefreshInspectionToDayDriverInDb(driver.Id);
                SendNotyfyInspactionDrive(driver.TokenShope, "Truck Inspection", "You can pass the truck inspection now");
            }
        }

        private void SendNotyfyInspactionDrive(string tokenShope, string title, string body)
        {
            if (tokenShope != null && tokenShope != "")
            {
                var payload = new
                {
                    to = tokenShope,
                    content_available = true,
                    notification = new
                    {
                        click_action = "Driver",
                        body = body,
                        title = title,
                        sound = "default",
                        badge = 1,
                    },
                };
                string postbody = JsonConvert.SerializeObject(payload).ToString();
                Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null) using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    string sResponseFromServer = tReader.ReadToEnd();
                                }
                        }
                    }
                }
            }
            InitReqvest();
        }
    }
}