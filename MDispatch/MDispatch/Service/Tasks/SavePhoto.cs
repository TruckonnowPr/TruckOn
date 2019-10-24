﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plugin.Settings;
using RestSharp;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MDispatch.Service.Tasks
{
    public class SavePhoto : ITask
    {
        private Inspection inspection = new Inspection(); 

        public void StartTask(params object[] task)
        {
            string token = (string)task[0];
            string vehiclwInformationId = (string)task[1];
            Models.PhotoInspection photoInspection = (Models.PhotoInspection)task[2];
            if (photoInspection.Damages != null)
            {
                photoInspection.Damages.ForEach((dm) =>
                {
                    dm.Image = null;
                    dm.ImageSource = null;
                });
            }
            StartTask1(token, vehiclwInformationId, photoInspection);
        }

        private void StartTask1(string token, string id, Models.PhotoInspection photoInspection)
        {
            IRestResponse response = null;
            string content = null;
            RestClient client = new RestClient(Config.BaseReqvesteUrl);
            RestRequest request = new RestRequest("api.Task/StartTask", Method.POST);
            client.Timeout = 60000;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("token", token);
            request.AddParameter("nameMethod", "SavePhoto");
            request.AddParameter("optionalParameter", $"{id}");
            response = client.Execute(request);
            content = response.Content;
            string res = GetData(content);
            if (res != null)
            {
                string photoInspectionJson = JsonConvert.SerializeObject(photoInspection);
                byte[] photoInspectionArray = Encoding.Default.GetBytes(photoInspectionJson);
                string photoInspectionBase64 = Convert.ToBase64String(photoInspectionArray);
                CrossSettings.Current.AddOrUpdateValue(res, photoInspectionBase64);
                CrossSettings.Current.AddOrUpdateValue(res+"Param", $"{token},{id}");
                string allTaskLoad = CrossSettings.Current.GetValueOrDefault("allTaskLoad", "");
                CrossSettings.Current.AddOrUpdateValue("allTaskLoad", allTaskLoad + "," + res); ;
                LoadTask1(token, res);
            }
            else
            {

            }
        }

        private void LoadTask1(string token, string idTask)
        {
            IRestResponse response = null;
            string content = null;
            string photoInspectionBase64 = CrossSettings.Current.GetValueOrDefault(idTask, null);
            if (photoInspectionBase64 != null)
            {
                RestClient client = new RestClient(Config.BaseReqvesteUrl);
                int countReqvest = photoInspectionBase64.Length / 256;
                for (int i = 0; i < countReqvest; i++)
                {
                    string photoInspectionTmp = GetRangeArray(photoInspectionBase64, 256);
                    var s = photoInspectionBase64.Remove(0, photoInspectionTmp.Length);
                    RestRequest request = new RestRequest("api.Task/LoadTask", Method.POST);
                    client.Timeout = 60000;
                    request.AddHeader("Accept", "application/json");
                    request.AddParameter("token", token);
                    request.AddParameter("idTask", idTask);
                    request.AddParameter("byteBase64", photoInspectionTmp);
                    response = client.Execute(request);
                    content = response.Content;
                    string res = GetData(content);
                    if(res != "No")
                    {
                        CrossSettings.Current.AddOrUpdateValue(idTask, photoInspectionBase64.Remove(0, photoInspectionTmp.Length));
                    }
                    else
                    {
                        //Wait or Remove, Roma needs to think about it more
                    }
                }
            }
            else
            {
                //RemoveTask
            }
        }

        private void EndTask1()
        {

        }


        private string GetData(string respJsonStr)
        {
            string res = null;
            respJsonStr = respJsonStr.Replace("\\", "");
            respJsonStr = respJsonStr.Remove(0, 1);
            respJsonStr = respJsonStr.Remove(respJsonStr.Length - 1);
            var responseAppS = JObject.Parse(respJsonStr);
            string status = responseAppS.Value<string>("Status");
            if (status == "success")
            {
                res = JsonConvert.DeserializeObject<string>(responseAppS.
                        SelectToken("ResponseStr").ToString());
                
            }
            return res;
        }

        private string GetRangeArray(string base64, int count)
        {
            string tmp = null;
            if (base64.Length != 0)
            {
                if(base64.Length >= count)
                {
                    for(int i = 0; i < count; i++)
                    {
                        tmp += base64[i];
                    }
                    return tmp;
                }
                else
                {
                    return base64;
                }
            }
            else
            {
                return null;
            }
        }

        //private byte[] ObjectToByteArray(Models.PhotoInspection obj)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    using (var ms = new MemoryStream())
        //    {
        //        bf.Serialize(ms, obj);
        //        return ms.ToArray();
        //    }
        //}
    }
}